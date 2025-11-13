using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint4;

namespace Tyuiu.DevyatovEV.Sprint4.Task7.V3.Lib
{
    public class DataService : ISprint4Task7V3
    {
        public int Calculate(int n, int m, string value)
        {
            int[,] matrix = new int[n, m];
            int count = 0;
            int index = 0;

            // Преобразуем строку в матрицу 4x2
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    // Преобразуем символ в цифру
                    matrix[i, j] = int.Parse(value[index].ToString());
                    index++;
                }
            }

            // Подсчитываем количество нечетных чисел
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    if (matrix[i, j] % 2 != 0)
                    {
                        count++;
                    }
                }
            }

            return count;
        }
    }
}