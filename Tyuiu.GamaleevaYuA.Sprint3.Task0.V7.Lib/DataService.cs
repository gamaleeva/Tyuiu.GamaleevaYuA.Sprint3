using tyuiu.cources.programming.interfaces.Sprint3;
namespace Tyuiu.GamaleevaYuA.Sprint3.Task0.V7.Lib
{
    public class DataService : ISprint3Task0V7
    {
        public double GetSumSeries(double value, int startValue, int stopValue)
        {
            double s = 0;
            for (int i = startValue; i <= stopValue; i++)
            {
                s += (Math.Pow(value, i) + 1) * Math.Cos(i);
            }
            return Math.Round(s, 3);
        }
    }
}
