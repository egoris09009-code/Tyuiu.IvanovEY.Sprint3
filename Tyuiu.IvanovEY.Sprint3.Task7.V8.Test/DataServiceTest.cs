using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.IvanovEY.Sprint3.Task7.V8.Lib;

namespace Tyuiu.IvanovEY.Sprint3.Task7.V8.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidGetMassFunction()
        {
            DataService ds = new DataService();
            int startValue = -5;
            int stopValue = 5;

            double[] res = ds.GetMassFunction(startValue, stopValue);

            Assert.AreEqual(11, res.Length);

            Assert.AreEqual(0, res[7]);
        }
    }
}