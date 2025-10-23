using Tyuiu.GamaleevaYuA.Sprint3.Task1.V29.Lib;
namespace Tyuiu.GamaleevaYuA.Sprint3.Task1.V29.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidGetMultiplySeries()
        {
            DataService ds = new DataService();
            double value = 0.25;
            int startValue = 1;
            int stopValue = 11;
            double wait = 4.54;
            double res = ds.GetMultiplySeries(value, startValue, stopValue);
            Assert.AreEqual(wait, res);
        }
    }
}
