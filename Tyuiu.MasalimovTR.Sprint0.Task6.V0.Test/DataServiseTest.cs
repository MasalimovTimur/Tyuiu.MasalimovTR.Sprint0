using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.MasalimovTR.Sprint0.Task6.V0.Lib;


namespace Tyuiu.MasalimovTR.Sprint0.Task6.V0.Test
{
    [TestClass]
    public class DataServiseTest
    {
        [TestMethod]
        public void CheckAdditionArrayValid()
        {
            var numbers = new int[] { 1, 2, 3, 4, 5 };
            var res = DataServise.AdditionArray(numbers);
            Assert.AreEqual(15, res);
        }
        [TestMethod]
        public void CheckMultiplicationArrayInvalid()
        {
            var numbers = new int[] { 1, 2, 3, 4, 5 };
            var res = DataServise.SubtractionArray(numbers);
            Assert.AreEqual(-15, res);
        }
        [TestMethod]
        public void CheckSubtractionArrayInvalid()
        {
            var numbers = new int[] { 1, 2, 3, 4, 5 };
            var res = DataServise.MultiplicationArray(numbers);
            Assert.AreEqual(120, res);
        }
    }
}
