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


    }
}