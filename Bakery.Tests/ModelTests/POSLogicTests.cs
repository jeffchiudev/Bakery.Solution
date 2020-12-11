using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using Bakery.Models;


namespace Bakery.Tests
{
    [TestClass]
    public class POSLogicTests
    {
        [TestMethod]
        public void Bread_MakeABreadOrder_constructor()
        {
            Bread testBreadOrder = new Bread(1);
            Assert.AreEqual(typeof(Bread), testBreadOrder.GetType());
        }    

        [TestMethod]
        public void Bread_CalculateCost_int()
        {
            Bread testBreadOrder = new Bread(1);
            Assert.AreEqual(5, testBreadOrder.BreadCost());
        }    

        [TestMethod]
        public void Bread_CalculateDiscount_int()
        {
            Bread testBreadOrder = new Bread(3);
            Assert.AreEqual(10, testBreadOrder.BreadCost());
        }    

        [TestMethod]
        public void Bread_CalculateDiscountForMore_int()
        {
            Bread testBreadOrder = new Bread(10);
            Assert.AreEqual(35, testBreadOrder.BreadCost());
        }

        [TestMethod]
        public void Pastry_MakePastryOrder_constructor()
        {
            Pastry testOrder = new Pastry(3);
            Assert.AreEqual(typeof(Pastry), testOrder.GetType());
        }

        [TestMethod]
        public void Pastry_CalculatePastryCost_int()
        {
            Pastry testOrder = new Pastry(1);
            Assert.AreEqual(2, testOrder.PastryCost());
        }

        [TestMethod]
        public void Pastry_CalculateDiscountForThree_int()
        {
            Pastry testOrder = new Pastry(3);
            Assert.AreEqual(5, testOrder.PastryCost());
        }

        [TestMethod]
        public void Pastry_CalculateDiscountForTen_int()
        {
            Pastry testOrder = new Pastry(10);
            Assert.AreEqual(17, testOrder.PastryCost());
        }
    }
}