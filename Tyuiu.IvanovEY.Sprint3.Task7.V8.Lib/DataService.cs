using tyuiu.cources.programming.interfaces.Sprint3;
namespace Tyuiu.IvanovEY.Sprint3.Task7.V8.Lib
{
    public class DataService : ISprint3Task7V8
    {
        public double[] GetMassFunction(int startValue, int stopValue)
        {
            int length = stopValue - startValue + 1;
            double[] result = new double[length];

            int index = 0;

            for (int x = startValue; x <= stopValue; x++)
            {
                if (2 - x == 0)
                {
                    result[index] = 0;
                }
                else
                {
                    double sinX = Math.Sin(x);
                    double cosX = Math.Cos(x);
                    double fraction = (cosX + 1) / (2 - x);

                    result[index] = Math.Round(sinX + fraction + 2 * x, 2);
                }

                index++;
            }

            return result;
        }
    }
}
