using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.DevyatovEV.Sprint4.Task0.V29.Lib;

namespace Tyuiu.DevyatovEV.Sprint4.Task0.V29
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #4 | Выполнил: Девятов Е.В. | ИСТНб-25-1";

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #4                                                               *");
            Console.WriteLine("* Тема: Одномерные массивы (статический ввод)                            *");
            Console.WriteLine("* Задание #0                                                              *");
            Console.WriteLine("* Вариант #29                                                             *");
            Console.WriteLine("* Выполнил: Девятов Егор Владимирович | ИСТНб-25-1                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дан одномерный целочисленный массив на 10 элементов                    *");
            Console.WriteLine("* заполненный статическими значениями в диапазоне от 0 до 9              *");
            Console.WriteLine("* подсчитать сумму нечетных элементов массива.                          *");
            Console.WriteLine("* Массив: {7, 4, 3, 2, 1, 5, 9, 8, 7, 4}                                *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            int[] array = { 7, 4, 3, 2, 1, 5, 9, 8, 7, 4 };

            Console.WriteLine("Исходный массив:");
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + " ");
            }
            Console.WriteLine();

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            int result = ds.GetSumOddArrEl(array);
            Console.WriteLine($"Сумма нечетных элементов массива = {result}");

            Console.ReadKey();
        }
    }
}