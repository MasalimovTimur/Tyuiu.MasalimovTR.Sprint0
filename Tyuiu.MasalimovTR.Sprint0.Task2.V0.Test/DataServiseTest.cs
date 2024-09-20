using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.MasalimovTR.Sprint0.Task2.V0.Lib;

namespace Tyuiu.MasalimovTR.Sprint0.Task2.V0.Test
{
    [TestClass]
    public class DataServiseTest
    {
        [TestMethod]
        public void CheckGetMassageValid()
        {
            var name = "Тимур";
            var res = DataServise.GetMassage(name);
            Assert.AreEqual("Привет..., Тимур", res); 
        }
    }
}
