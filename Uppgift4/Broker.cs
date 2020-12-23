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

        public bool AddRealEstate(RealEstate realEstate)
        {
            RealEstates.Add(realEstate);
            return true;
        }

    }
}
