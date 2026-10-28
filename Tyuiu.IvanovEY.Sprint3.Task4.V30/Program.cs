using System;
using Tyuiu.IvanovEY.Sprint3.Task4.V30.Lib;

namespace Tyuiu.IvanovEY.Sprint3.Task4.V30
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Спринт #3 | Выполнил: Иванов Е. Ю. | ИСТНб 26-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #3                                                               *");
            Console.WriteLine("* Тема: Использование операторов continue и break в циклах                *");
            Console.WriteLine("* Задание #4                                                              *");
            Console.WriteLine("* Вариант #30                                                             *");
            Console.WriteLine("* Выполнил: Иванов Е. Ю. | ИСТНб 26-1                                     *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* На отрезке, где x принимает значения от -5 до 5, вычислить значение     *");
            Console.WriteLine("* функции y=sin(x)/x. При x = 0 пропустить значение.                      *");
            Console.WriteLine("* Полученные значения суммировать.                                        *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Диапазон x: от -5 до 5                                                  *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            int startValue = -5;
            int stopValue = 5;

            DataService ds = new DataService();
            double result = ds.Calculate(startValue, stopValue);

            Console.WriteLine("* Сумма значений = " + result);
            Console.WriteLine("***************************************************************************");

            Console.ReadLine();
        }
    }
}