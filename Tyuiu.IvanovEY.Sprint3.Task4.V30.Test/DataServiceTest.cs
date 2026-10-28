using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.IvanovEY.Sprint3.Task4.V30.Lib;

namespace Tyuiu.IvanovEY.Sprint3.Task4.V30.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();
            int startValue = -5;
            int stopValue = 5;

            double res = ds.Calculate(startValue, stopValue);

            Assert.AreNotEqual(0, res);
        }
    }
}