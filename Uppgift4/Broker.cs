using System;
using System.Collections.Generic;
using System.Text;

namespace Uppgift4
{
    public class Broker
    {
        public List<RealEstate> RealEstates { get; set; }// = new List<RealEstate>(); 

        public Broker()
        {
            RealEstates = new List<RealEstate>()
            {
                new RealEstate() {Id=1, Address="Gågatan 22", Rooms=1, Area=57},
                new RealEstate() {Id=4, Address="Strandvägen 1",  Rooms=6, Area=125},
                new RealEstate() {Id=5, Address="Humlestigen 14", Rooms=5, Area=125 },
                new RealEstate() {Id=9, Address="Ljunggatan 12 b", Rooms=1, Area=42 }
            };
        }

        public List<RealEstate> SortBy(int minRoom, int maxRoom)
        {
            List<RealEstate> sortedRealEstate = new List<RealEstate>();

            foreach (RealEstate realEstate in RealEstates)
            {
                if (realEstate.Rooms >= minRoom & realEstate.Rooms <= maxRoom)
                {
                    sortedRealEstate.Add(realEstate);
                }
            }
            RealEstates = sortedRealEstate;
            return sortedRealEstate;
        }

        public int CheckId(List<RealEstate> RealEstates)
        {
            int ID = 0;
            
            foreach (RealEstate realEstate in RealEstates)
            {
                if (realEstate.Id > ID)
                {
                    ID = realEstate.Id;
                }
            }
            return (ID + 1);
        }

        public bool CheckFactor(double area, double rooms)
        {
            double factor = area / rooms;

            if (factor < 10 | factor > 50)
            {
                return false;
            }
            return true;
        }

        public bool AddRealEstate(RealEstate realEstate)
        {
            if (realEstate == null)
            {
                return false;
            }
            if (CheckFactor(realEstate.Area, realEstate.Rooms) == false)
            {
                return false;
            }
            else
            {
                int freeId = CheckId(RealEstates);
                realEstate.Id = freeId;
                RealEstates.Add(realEstate);
                return true;
            }
            
        }

    }
}
