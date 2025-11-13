using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.DevyatovEV.Sprint4.Task4.V12.Lib;

namespace Tyuiu.DevyatovEV.Sprint4.Task4.V12
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #4 | Выполнил: Девятов Е.В. | ИСТНб-25-1";

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #4                                                               *");
            Console.WriteLine("* Тема: Двумерные массивы (ввод с клавиатуры)                            *");
            Console.WriteLine("* Задание #4                                                              *");
            Console.WriteLine("* Вариант #12                                                             *");
            Console.WriteLine("* Выполнил: Девятов Егор Владимирович | ИСТНб-25-1                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дан двумерный целочисленный массив 5 на 5 элементов,                   *");
            Console.WriteLine("* заполненный значениями с клавиатуры в диапазоне от 2 до 8.             *");
            Console.WriteLine("* Заменить четные элементы массива на 1.                                 *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            int[,] matrix = new int[5, 5];

            Console.WriteLine("Введите 25 целых чисел от 2 до 8 для массива 5x5:");
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    Console.Write($"Элемент [{i},{j}]: ");
                    matrix[i, j] = Convert.ToInt32(Console.ReadLine());

                    // Проверка диапазона
                    while (matrix[i, j] < 2 || matrix[i, j] > 8)
                    {
                        Console.WriteLine("Ошибка! Число должно быть от 2 до 8.");
                        Console.Write($"Элемент [{i},{j}]: ");
                        matrix[i, j] = Convert.ToInt32(Console.ReadLine());
                    }
                }
            }

            Console.WriteLine("\nИсходный массив:");
            PrintMatrix(matrix);

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            int[,] resultMatrix = ds.Calculate(matrix);

            Console.WriteLine("Массив после замены четных элементов на 1:");
            PrintMatrix(resultMatrix);

            Console.ReadKey();
        }

        static void PrintMatrix(int[,] matrix)
        {
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    Console.Write(matrix[i, j] + "\t");
                }
                Console.WriteLine();
            }
        }
    }
}