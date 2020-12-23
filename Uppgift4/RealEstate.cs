using System;
using System.Collections.Generic;
using System.Text;

namespace Uppgift4
{
    public class RealEstate
    {
        public int Id { get; set; }
        public string Address { get; set; }
        public int Rooms { get; set; }
        public int Area { get; set; }

        //public RealEstate(string adress)
        //{
        //    Adress = adress;
        //}

        public override string ToString()
        {
            return Address;
        }
    }
}
