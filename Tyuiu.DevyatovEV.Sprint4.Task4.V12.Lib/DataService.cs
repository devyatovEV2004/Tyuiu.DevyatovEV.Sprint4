using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint4;

namespace Tyuiu.DevyatovEV.Sprint4.Task4.V12.Lib
{
    public class DataService : ISprint4Task4V12
    {
        public int[,] Calculate(int[,] matrix)
        {
            int rows = matrix.GetLength(0);
            int cols = matrix.GetLength(1);

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    if (matrix[i, j] % 2 == 0) // Проверка на четность
                    {
                        matrix[i, j] = 1; // Замена четных элементов на 1
                    }
                }
            }

            return matrix;
        }
    }
}