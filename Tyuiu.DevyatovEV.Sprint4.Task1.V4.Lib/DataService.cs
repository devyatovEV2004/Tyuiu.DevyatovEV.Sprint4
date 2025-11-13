using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint4;

namespace Tyuiu.DevyatovEV.Sprint4.Task1.V4.Lib
{
    public class DataService : ISprint4Task1V4
    {
        public int Calculate(int[] array)
        {
            int product = 1;

            foreach (int num in array)
            {
                if (num % 2 != 0) // Проверка на нечетность
                {
                    product *= num;
                }
            }

            return product;
        }
    }
}