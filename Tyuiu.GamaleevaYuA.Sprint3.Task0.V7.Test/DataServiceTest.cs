﻿using Tyuiu.GamaleevaYuA.Sprint3.Task0.V7.Lib;
namespace Tyuiu.GamaleevaYuA.Sprint3.Task0.V7.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidGetSumSeries()
        {
            DataService ds = new DataService();
            double value = 0.75;
            int startValue = 1;
            int stopValue = 20;
            double res = ds.GetSumSeries(value, startValue, stopValue);
            double wait = -0.206;
            Assert.AreEqual(res, wait);

        }
    }
}
