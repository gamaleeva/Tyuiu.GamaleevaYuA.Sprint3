using System.Security.Cryptography;
using tyuiu.cources.programming.interfaces.Sprint3;
namespace Tyuiu.GamaleevaYuA.Sprint3.Task6.V14.Lib
{
    public class DataService : ISprint3Task6V14
    {
        public int GetSumTheDivisors(int startValue, int stopValue)
        {
            int count = 0;
            for (int i = startValue; i <= stopValue; i++)
            {
               for (int d = 1; d <= i; d++)
                {
                    if ((i % d == 0) && (d > 5))
                    {
                        count++;

                    }
                }
            }
            return count;
        }
    }
}
