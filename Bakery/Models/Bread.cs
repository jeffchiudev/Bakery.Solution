using System;
using System.Collections.Generic;

namespace Bakery.Models
{
    public class Bread
    {
        public int BreadQuantity {get; set;}
        private static List<Bread> _instances = new List<Bread> {};
        public static List<Bread> GetAll()
        {
            return _instances;
        }

        public static void ClearAll()
        {
            _instances.Clear();
        }
        public Bread(int breadQuantity)
        {
            BreadQuantity = breadQuantity;
        }

        public int BreadCost()
        {
            int breadCost = 5;
            int discountCalc = BreadQuantity / 3;
            int finalBreadCost = (BreadQuantity * breadCost) - (breadCost * discountCalc);
            return finalBreadCost;
        }
    }
}

//BL goes here