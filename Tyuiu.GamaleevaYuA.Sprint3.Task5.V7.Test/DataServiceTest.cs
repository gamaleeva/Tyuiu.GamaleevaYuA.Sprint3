﻿using Tyuiu.GamaleevaYuA.Sprint3.Task5.V7.Lib;
namespace Tyuiu.GamaleevaYuA.Sprint3.Task5.V7.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidGetSumSumSeries()
        {
            DataService ds = new DataService();
            int startValue1 = 1;
            int startValue2 = 1;
            int stopValue1 = 3;
            int stopValue2 = 10;
            int x = 5;
            double wait = 130.917;
            double res = ds.GetSumSumSeries(x, startValue1, startValue2, stopValue1, stopValue2);
            Assert.AreEqual(wait, res);

        }
    }
}
