using Tyuiu.GamaleevaYuA.Sprint3.Task2.V8.Lib;
namespace Tyuiu.GamaleevaYuA.Sprint3.Task2.V8.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidGetMultiplySeries()
        {
            DataService ds = new DataService();
            int startValue = 1;
            int stopValue = 15;
            double wait = 0;
            double res = ds.GetMultiplySeries(startValue, stopValue);
            Assert.AreEqual(wait, res);
        }
    }
}
