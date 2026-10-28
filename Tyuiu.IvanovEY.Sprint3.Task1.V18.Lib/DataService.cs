using tyuiu.cources.programming.interfaces.Sprint3;
namespace Tyuiu.IvanovEY.Sprint3.Task1.V18.Lib
{
    public class DataService : ISprint3Task1V18
    {
        public double GetSumSeries(int startValue, int stopValue)
        {
            double sum = 0;
            int i = startValue;
            double constant = Math.Pow(0.25, 2);
            while (i <= stopValue)
            {        
                double term = Math.Sin(i) * constant;             
                sum += term;     
                i++;
            }
            return Math.Round(sum, 3);
        }
    }
}
