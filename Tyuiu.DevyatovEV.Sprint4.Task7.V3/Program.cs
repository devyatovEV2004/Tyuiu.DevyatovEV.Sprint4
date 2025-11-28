using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.DevyatovEV.Sprint4.Task7.V3.Lib;

namespace Tyuiu.DevyatovEV.Sprint4.Task7.V3
{
    class Program
{
    static void Main(string[] args)
    {
        int n = 4;
        int m = 2;
        int[,] mtrx = new int[n, m];
        string value = "27182818";
        DataService ds = new DataService();

        Console.Title = "Спринт #4 | Выполнил: Девятов Е.В. | ИСТНб-25-1";

        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* Спринт #4                                                               *");
        Console.WriteLine("* Тема: Обработка строковых данных                                        *");
        Console.WriteLine("* Задание #7                                                              *");
        Console.WriteLine("* Вариант #3                                                              *");
        Console.WriteLine("* Выполнил: Девятов Егор Владимирович | ИСТНб-25-1                        *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* УСЛОВИЕ:                                                                *");
        Console.WriteLine("* Дана строка из одноразрядных цифр '27182818'.                          *");
        Console.WriteLine("* Преобразуйте ее в матрицу 4 на 2 и подсчитайте количество нечетных     *");
        Console.WriteLine("* чисел в матрице.                                                        *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
        Console.WriteLine("***************************************************************************");

        int index = 0;

        Console.WriteLine("Массив:");
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < m; j++)
            {
                Console.Write($"{value[index]} \t");
                index++;
            }
            Console.WriteLine();
        }
        Console.WriteLine();
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
        Console.WriteLine("***************************************************************************");

        int res = ds.Calculate(n, m, value);
        Console.WriteLine("Количество нечетных чисел в матрице = " + res);

        Console.ReadLine();
    }
}
}