using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.MasalimovTR.Sprint0.Task3.V0.lib;

namespace Tyuiu.MasalimovTR.Sprint0.Task3.V0.Test
{
    [TestClass]
    public class DataServiseTest
    {
        [TestMethod]
        public void CheckedValid()
        {
            Assert.AreEqual(10, DataServise.sum(5, 5));
        }
    }
}
