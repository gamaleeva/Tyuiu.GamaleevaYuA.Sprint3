using Tyuiu.GamaleevaYuA.Sprint3.Task6.V14.Lib;
namespace Tyuiu.GamaleevaYuA.Sprint3.Task6.V14.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidSumTheDivisors()
        {
            DataService ds = new DataService();
            int startValue = 7;
            int stopValue = 16;
            int wait = 13;
            int res = ds.GetSumTheDivisors(startValue, stopValue);
            Assert.AreEqual(wait, res);
        }
    }
}
