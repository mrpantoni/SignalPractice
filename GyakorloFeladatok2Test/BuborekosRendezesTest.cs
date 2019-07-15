using System;
using System.Collections.Generic;
using System.Linq;
using GyakorloFeladatok2;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace GyakorloFeladatok2Test
{
    [TestClass]
    public class BuborekosRendezesTest
    {
        [TestMethod]
        public void TestBuborekos()
        {
            BuborekosRendezes buborekos = new BuborekosRendezes();
            int[] numArray = new int[] { 1, 3, 6, 2, 0 };
            int[] expected = new int[] { 0, 1, 2, 3, 6 };
            int[] actual = buborekos.Buborekos(numArray);

            Assert.IsTrue(expected.SequenceEqual(actual));
        }
    }
}
