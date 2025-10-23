using tyuiu.cources.programming.interfaces.Sprint3;
namespace Tyuiu.GamaleevaYuA.Sprint3.Task1.V29.Lib
{
    public class DataService : ISprint3Task1V29
    {
        public double GetMultiplySeries(double value, int startValue, int stopValue)
        {
            double result = 1;
            while (startValue <=  stopValue)
            {
                result = result * ((value * value * startValue) + 2);
                startValue++;
            }
            return Math.Round(result, 3);
            
        }
    }
}
