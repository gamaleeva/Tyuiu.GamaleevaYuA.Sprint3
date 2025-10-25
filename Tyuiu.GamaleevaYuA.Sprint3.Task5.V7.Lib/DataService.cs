using tyuiu.cources.programming.interfaces.Sprint3;
namespace Tyuiu.GamaleevaYuA.Sprint3.Task5.V7.Lib
{
    public class DataService : ISprint3Task5V7
    {
        public double GetSumSumSeries(int x, int startValue1, int startValue2, int stopValue1, int stopValue2)
        {
            double res = 0;
            for (int i = startValue1; i <= stopValue1; i++)
            {
                for ( int k = startValue2; k <= stopValue2; k++)
                {
                    res += 1 / Math.Cos(k) + x;
                    
                }
            }
            return Math.Round(res, 3);
        }
    }
}
