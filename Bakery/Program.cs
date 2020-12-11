using System;
using System.Collections.Generic;
using Bakery.Models;


namespace Bakery
{
    public class Program
    {
        public static void Main()
        {
            Console.WriteLine("Welcome to Pierre's Bakery!");
            Console.WriteLine("---------------------------");
            Console.WriteLine("We've got the best baguettes & croissant in town,");
            Console.WriteLine("baguettes are $5.00/ea, croissant are $2.00/ea.");
            Console.WriteLine("We're running a special: buy 2 baguette get one free and");
            Console.WriteLine("buy 3 croissant for $5.00");
            Console.WriteLine("---------------------------");
            Console.WriteLine("How many baguette would you like?");
            string stringNumberOfBread = Console.ReadLine();
            int numberOfBread = int.Parse(stringBreadOrder);
            Bread breadOrder = new Bread(numberOfBread);
            Console.WriteLine("How many croissant would you like?");
            string stringNumberOfPastry = Console.ReadLine();
            int numberOfPastry = int.Parse(stringNumberOfPastry);
            Pastry pastryOrder = new Pastry(numberOfPastry);
            string orderSummary = $"Your order: {breadOrder} baguette and {pastryOrder} croissant."
            Console.WriteLine("orderSummary");
            int totalOrder = breadOrder()

            

        }
    }
}