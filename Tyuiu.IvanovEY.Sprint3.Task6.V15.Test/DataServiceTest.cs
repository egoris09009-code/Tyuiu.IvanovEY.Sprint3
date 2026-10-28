using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.IvanovEY.Sprint3.Task6.V15.Lib;

namespace Tyuiu.IvanovEY.Sprint3.Task6.V15.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidGetSumTheDivisors()
        {
            DataService ds = new DataService();
            int startValue = 6;
            int stopValue = 15;

            int res = ds.GetSumTheDivisors(startValue, stopValue);

            Assert.AreNotEqual(0, res);
        }
    }
}