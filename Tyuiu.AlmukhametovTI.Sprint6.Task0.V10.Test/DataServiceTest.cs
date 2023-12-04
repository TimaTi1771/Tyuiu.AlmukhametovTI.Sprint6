using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.AlmukhametovTI.Sprint6.Task0.V10.Lib;

namespace Tyuiu.AlmukhametovTI.Sprint6.Task0.V10.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            double res = ds.Calculate(2);
            double wait = 37.56;
            Assert.AreEqual(res, wait);
        }
    }
}
