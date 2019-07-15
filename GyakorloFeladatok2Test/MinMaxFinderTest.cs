using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace GyakorloFeladatok2.Test
{
    [TestClass]
    public class MinMaxFinderTest
    {
        [TestMethod]
        public void TestFindMaxFromList()
        {
            MinMaxFinder finder = new MinMaxFinder();
            List<int> ints = new List<int>() { 1, 3, -4, 6, 2, 0};

            Assert.AreEqual(6, finder.FindMax(ints));
        }
        [TestMethod]
        public void TestFindMinFromList()
        {
            MinMaxFinder finder = new MinMaxFinder();
            List<int> ints = new List<int>() { 1, 3, -4, 6, 2, 0 };

            Assert.AreEqual(-4, finder.FindMin(ints));
        }
    }

}
