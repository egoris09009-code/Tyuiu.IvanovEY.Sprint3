using Tyuiu.IvanovEY.Sprint3.Task0.V13.Lib;

namespace Tyuiu.IvanovEY.Sprint3.Task0.V13.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidGetSumSeries()
        {
            DataService ds = new DataService();
            double value = 0.5;
            int startValue = 1;
            int stopValue = 20;

            double res = ds.GetSumSeries(value, startValue, stopValue);      
            Assert.AreNotEqual(0, res);
        }
    }
}
