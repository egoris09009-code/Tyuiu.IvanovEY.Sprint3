using System;
using Tyuiu.IvanovEY.Sprint3.Task7.V8.Lib;

namespace Tyuiu.IvanovEY.Sprint3.Task7.V8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Спринт #3 | Выполнил: Иванов Е. Ю. | ИСТНб 26-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #3                                                               *");
            Console.WriteLine("* Тема: Обработка и вывод в виде таблицы                                  *");
            Console.WriteLine("* Задание #7                                                              *");
            Console.WriteLine("* Вариант #8                                                              *");
            Console.WriteLine("* Выполнил: Иванов Е. Ю. | ИСТНб 26-1                                     *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу, которая выводит таблицу значений функции:           *");
            Console.WriteLine("* F(x) = sin(x) + (cos(x)+1)/(2-x) + 2x                                   *");
            Console.WriteLine("* на заданном диапазоне [-5; 5] с шагом 1.                                *");
            Console.WriteLine("* Произвести проверку деления на ноль.                                    *");
            Console.WriteLine("* При делении на ноль вернуть значение 0.                                 *");
            Console.WriteLine("* Значения округлить до двух знаков после запятой.                        *");
            Console.WriteLine("* Значения занести в массив!                                              *");
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
            double[] result = ds.GetMassFunction(startValue, stopValue);

            Console.WriteLine("* Таблица значений функции:                                               *");
            Console.WriteLine("* X\t|\tF(X)\t\t\t\t\t\t\t\t\t\t\t\t\t*");
            Console.WriteLine("*-------------------------------------------------------------*");

            for (int i = 0; i < result.Length; i++)
            {
                int x = startValue + i;
                Console.WriteLine("* " + x + "\t|\t" + result[i] + "           *");
            }

            Console.WriteLine("***************************************************************************");

            Console.ReadLine();
        }
    }
}