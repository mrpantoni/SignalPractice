using FactorialExercise.Exercises;
using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace RecursionExercise.Tests
{
    [TestClass]
    public class FactorialTest
    {
        [TestMethod]
        public void TestFactorialCalculation()
        {
            Assert.AreEqual(1, FactorialCalculator.FactorialRecursion(1));
            Assert.AreEqual(6, FactorialCalculator.FactorialRecursion(3));
            Assert.AreEqual(120, FactorialCalculator.FactorialRecursion(5));
        }

        [TestMethod]
        public void TestHatvanyCalculator()
        {
            Assert.AreEqual(1, FactorialCalculator.ExponentiationRecursion(2, 0));
            Assert.AreEqual(256, FactorialCalculator.ExponentiationRecursion(2, 8));
            Assert.AreEqual(19683, FactorialCalculator.ExponentiationRecursion(3, 9));
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TestHatvanyCalculato()
        {
            FactorialCalculator.FactorialRecursion(-3);
            FactorialCalculator.ExponentiationRecursion(-2, 8);
        }
    }
}