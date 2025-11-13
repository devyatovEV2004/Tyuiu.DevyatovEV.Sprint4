using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.DevyatovEV.Sprint4.Task3.V10.Lib;

namespace Tyuiu.DevyatovEV.Sprint4.Task3.V10
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #4 | Выполнил: Девятов Е.В. | ИСТНб-25-1";

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #4                                                               *");
            Console.WriteLine("* Тема: Двумерные массивы (статический ввод)                             *");
            Console.WriteLine("* Задание #3                                                              *");
            Console.WriteLine("* Вариант #10                                                             *");
            Console.WriteLine("* Выполнил: Девятов Егор Владимирович | ИСТНб-25-1                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дан двумерный целочисленный массив 5 на 5 элементов,                   *");
            Console.WriteLine("* заполненный статическими значениями в диапазоне от 4 до 8.             *");
            Console.WriteLine("* Найдите максимальный элемент в третьей строке массива.                 *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            int[,] array = new int[5, 5] {
                { 5, 7, 6, 6, 5 },
                { 5, 5, 5, 4, 6 },
                { 8, 5, 7, 4, 7 },
                { 7, 6, 7, 4, 7 },
                { 5, 8, 7, 8, 8 }
            };

            Console.WriteLine("Исходный массив 5x5:");
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    Console.Write(array[i, j] + "\t");
                }
                Console.WriteLine();
            }

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            int result = ds.Calculate(array);
            Console.WriteLine($"Максимальный элемент в третьей строке = {result}");

            Console.ReadKey();
        }
    }
}