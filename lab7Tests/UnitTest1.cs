using lab7;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace lab7Tests
{
    [TestClass]
    public class Lab7Tests
    {
        [TestMethod]
        public void TestTheater()
        {
            var theater = new Theater("Cambridge Theatre", "32-34 Earlham Street, London, WC2H 9HU", 1283, true);
            theater.CloseBuilding();
            Assert.IsFalse(theater.IsOpen);
            Assert.AreEqual(theater.ToString(), "Cambridge Theatre, Address: 32-34 Earlham Street, London, WC2H 9HU, Capacity: 1283, Closed!!!");
        }
    }
}
