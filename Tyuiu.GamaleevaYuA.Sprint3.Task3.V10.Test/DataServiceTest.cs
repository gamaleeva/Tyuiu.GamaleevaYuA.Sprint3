using Tyuiu.GamaleevaYuA.Sprint3.Task3.V10.Lib;
namespace Tyuiu.GamaleevaYuA.Sprint3.Task3.V10.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidDeleteCharInString()
        {
            DataService ds = new DataService();
            string str = "gdfppf vfppt p";
            string wait = "gdff vft ";
            char ch = 'p';
            string res = ds.DeleteCharInString(str, ch);
            Assert.AreEqual(wait, res);
        }
    }
}
