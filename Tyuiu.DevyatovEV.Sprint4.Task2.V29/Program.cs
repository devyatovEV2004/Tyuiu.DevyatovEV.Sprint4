using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.DevyatovEV.Sprint4.Task2.V29.Lib;

namespace Tyuiu.DevyatovEV.Sprint4.Task2.V29
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Random rand = new Random();

            Console.Title = "Спринт #4 | Выполнил: Девятов Е.В. | ИСТНб-25-1";

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #4                                                               *");
            Console.WriteLine("* Тема: Одномерные массивы (случайный ввод)                              *");
            Console.WriteLine("* Задание #2                                                              *");
            Console.WriteLine("* Вариант #29                                                             *");
            Console.WriteLine("* Выполнил: Девятов Егор Владимирович | ИСТНб-25-1                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дан одномерный целочисленный массив на 11 элементов                    *");
            Console.WriteLine("* заполненный случайными значениями в диапазоне от 1 до 8                *");
            Console.WriteLine("* подсчитать произведение четных элементов массива.                      *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            int[] array = new int[11];

            Console.WriteLine("Случайный массив из 11 элементов (от 1 до 8):");
            for (int i = 0; i < 11; i++)
            {
                array[i] = rand.Next(1, 9); // от 1 до 8 включительно
                Console.Write(array[i] + " ");
            }
            Console.WriteLine();

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            int result = ds.Calculate(array);
            Console.WriteLine($"Произведение четных элементов массива = {result}");

            Console.ReadKey();
        }
    }
}