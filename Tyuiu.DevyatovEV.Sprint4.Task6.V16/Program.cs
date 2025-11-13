using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.DevyatovEV.Sprint4.Task6.V16.Lib;

namespace Tyuiu.DevyatovEV.Sprint4.Task6.V16
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #4 | Выполнил: Девятов Е.В. | ИСТНб-25-1";

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #4                                                               *");
            Console.WriteLine("* Тема: Класс Array                                                       *");
            Console.WriteLine("* Задание #6                                                              *");
            Console.WriteLine("* Вариант #16                                                             *");
            Console.WriteLine("* Выполнил: Девятов Егор Владимирович | ИСТНб-25-1                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дан строковый массив данных:                                           *");
            Console.WriteLine("* ['Автомобиль', 'Велосипед', 'Самолет', 'Поезд', 'Трамвай',            *");
            Console.WriteLine("*  'Троллейбус', 'Метро']                                                *");
            Console.WriteLine("* используя класс Array, выведите элементы массива, длина которых        *");
            Console.WriteLine("* равна 7 символам.                                                      *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            string[] array = { "Автомобиль", "Велосипед", "Самолет", "Поезд", "Трамвай", "Троллейбус", "Метро" };

            Console.WriteLine("Исходный массив:");
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine($"[{i}] {array[i]} (длина: {array[i].Length})");
            }

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            string[] result = ds.Calculate(array);

            Console.WriteLine("Элементы массива длиной 7 символов:");
            if (result.Length > 0)
            {
                for (int i = 0; i < result.Length; i++)
                {
                    Console.WriteLine($"{result[i]} (длина: {result[i].Length})");
                }
            }
            else
            {
                Console.WriteLine("Элементов длиной 7 символов не найдено.");
            }

            Console.ReadKey();
        }
    }
}