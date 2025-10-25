using Tyuiu.GamaleevaYuA.Sprint3.Task4.V20.Lib;
namespace Tyuiu.GamaleevaYuA.Sprint3.Task4.V20.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();
            double wait = 10.483;
            int start = -5;
            int stop = 5;
            double res = ds.Calculate(start, stop);
            Assert.AreEqual(wait, res);
        }
    }
}
