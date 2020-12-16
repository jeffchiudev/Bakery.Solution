using System;
using System.Collections.Generic;

namespace Bakery.Models
{
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