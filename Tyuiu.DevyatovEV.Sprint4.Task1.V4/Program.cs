using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.DevyatovEV.Sprint4.Task1.V4.Lib;

namespace Tyuiu.DevyatovEV.Sprint4.Task1.V4
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #4 | Выполнил: Девятов Е.В. | ИСТНб-25-1";

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #4                                                               *");
            Console.WriteLine("* Тема: Одномерные массивы (ввод с клавиатуры)                           *");
            Console.WriteLine("* Задание #1                                                              *");
            Console.WriteLine("* Вариант #4                                                              *");
            Console.WriteLine("* Выполнил: Девятов Егор Владимирович | ИСТНб-25-1                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дан одномерный целочисленный массив на 10 элементов                    *");
            Console.WriteLine("* заполненный значениями с клавиатуры в диапазоне от 1 до 9              *");
            Console.WriteLine("* подсчитать произведение нечетных элементов массива.                    *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            int[] array = new int[10];

            Console.WriteLine("Введите 10 целых чисел от 1 до 9:");
            for (int i = 0; i < 10; i++)
            {
                Console.Write($"Элемент {i + 1}: ");
                array[i] = Convert.ToInt32(Console.ReadLine());

                // Проверка диапазона
                while (array[i] < 1 || array[i] > 9)
                {
                    Console.WriteLine("Ошибка! Число должно быть от 1 до 9.");
                    Console.Write($"Элемент {i + 1}: ");
                    array[i] = Convert.ToInt32(Console.ReadLine());
                }
            }

            Console.WriteLine("Введенный массив:");
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + " ");
            }
            Console.WriteLine();

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            int result = ds.Calculate(array);
            Console.WriteLine($"Произведение нечетных элементов массива = {result}");

            Console.ReadKey();
        }
    }
}