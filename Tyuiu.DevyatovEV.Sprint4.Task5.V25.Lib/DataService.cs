using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint4;

namespace Tyuiu.DevyatovEV.Sprint4.Task5.V25.Lib
{
    public class DataService : ISprint4Task5V25
    {
        public int Calculate(int[,] matrix)
        {
            int rows = matrix.GetLength(0);
            int cols = matrix.GetLength(1);
            int sum = 0;

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    if (matrix[i, j] > 0) // Проверка на положительность
                    {
                        sum += matrix[i, j];
                    }
                }
            }

            return sum;
        }
    }
}