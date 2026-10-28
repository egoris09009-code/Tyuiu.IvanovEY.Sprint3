using tyuiu.cources.programming.interfaces.Sprint3;
namespace Tyuiu.IvanovEY.Sprint3.Task3.V24.Lib
{
    public class DataService : ISprint3Task3V24
    {
        public string ReplaceCharInString(string value, char replaceable, char replacement)
        {
            string result = "";

            foreach (char c in value)
            {

                if (c == replaceable)
                {
                    result += replacement; 
                }
                else
                {
                    result += c; 
                }
            }

            return result;
        }
    }
}
