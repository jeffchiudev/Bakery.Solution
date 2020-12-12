using System;
using System.Collections.Generic;

namespace Bakery.Models
{
    public class Bread
    {
        public int BreadQuantity {get; set;}
        private static List<Bread> _instances = new List<Bread> {};
        public static List<Item> GetAll()
        {
            return _instances;
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

    public class Pastry
    {
        public int PastryQuantity {get;set;}
       
        public Pastry(int pastryQuantity)
        {
            PastryQuantity = pastryQuantity;
            _instances.Add(this);
        }

        public int PastryCost()
        {
            int pastryCost = 2;
            int discountCalc =  PastryQuantity / 3;
            int finalPastryPrice = (PastryQuantity * pastryCost) - discountCalc;
            return finalPastryPrice;
        }
    }
}

//BL goes here