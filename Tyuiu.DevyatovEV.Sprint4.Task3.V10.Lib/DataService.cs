using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint4;

namespace Tyuiu.DevyatovEV.Sprint4.Task3.V10.Lib
{
    public class DataService : ISprint4Task3V10
    {
        public int Calculate(int[,] array)
        {
            int rows = array.GetLength(0);
            int columns = array.GetLength(1);

            int maxElement = array[2, 0];

            for (int j = 0; j < columns; j++)
            {
                if (array[2, j] > maxElement)
                {
                    maxElement = array[2, j];
                }
            }

            return maxElement;
        }
    }
}