using System;
using System.Collections.Generic;

// 2 classes bread & Pastry
// UI includes cost of both items: bread $5, pastry %2
// User specifies the number of each they'd like
// app returns total cost of order
// bread special: buy 2 get one free; i.e. 3 bread = 10$
// pastry special: buy 3 for 5$
namespace Bakery.Models
{
    public class Bread
    {
        public int BreadQuantity {get; set;}
        public Bread(int breadQuantity)
        {
            BreadQuantity = breadQuantity;
        }

        public int BreadCost()
        {
            int breadCost = 5;
            return BreadQuantity * breadCost;
        }
    }

    public class Pastry
    {
        public int PastryQuantity {get;set;}
        
        public Pastry(int pastryQuantity)
        {
            PastryQuantity = pastryQuantity;
        }

        public int PastryCost()
        {
            int pastryCost = 2;
            return PastryQuantity * pastryCost;
        }
    }
}

//BL goes here