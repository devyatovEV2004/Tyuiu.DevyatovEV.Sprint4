using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.DevyatovEV.Sprint4.Task5.V25.Lib;

namespace Tyuiu.DevyatovEV.Sprint4.Task5.V25
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
            Console.WriteLine("* Тема: Двумерные массивы (случайный ввод)                               *");
            Console.WriteLine("* Задание #5                                                              *");
            Console.WriteLine("* Вариант #25                                                             *");
            Console.WriteLine("* Выполнил: Девятов Егор Владимирович | ИСТНб-25-1                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дан двумерный целочисленный массив 5 на 5 элементов,                   *");
            Console.WriteLine("* заполненный случайными значениями в диапазоне от -4 до 3.              *");
            Console.WriteLine("* Найти сумму положительных элементов.                                   *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            int[,] matrix = new int[5, 5];

            Console.WriteLine("Случайный массив 5x5 (значения от -4 до 3):");
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    matrix[i, j] = rand.Next(-4, 4); // от -4 до 3 включительно
                    Console.Write(matrix[i, j] + "\t");
                }
                Console.WriteLine();
            }

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            int result = ds.Calculate(matrix);
            Console.WriteLine($"Сумма положительных элементов = {result}");

            Console.ReadKey();
        }
    }
}