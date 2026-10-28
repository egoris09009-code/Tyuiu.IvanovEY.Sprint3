using tyuiu.cources.programming.interfaces.Sprint3;
namespace Tyuiu.IvanovEY.Sprint3.Task2.V11.Lib
{
    public class DataService : ISprint3Task2V11
    {
        public double GetSumSeries(double value, int startValue, int stopValue)
        {
            double sum = 0;
            int i = startValue;

            do
            {
                double innerPart = 1.0 / (3 + Math.Pow(value, i));

                double term = Math.Pow(innerPart, i);

                sum += term;

                i++;
            }
            while (i <= stopValue);

            return Math.Round(sum, 3);
        }
    }
}
