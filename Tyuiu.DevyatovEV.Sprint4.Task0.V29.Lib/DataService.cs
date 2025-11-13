using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint4;

namespace Tyuiu.DevyatovEV.Sprint4.Task0.V29.Lib
{
    public class DataService : ISprint4Task0V29
    {
        public int GetSumOddArrEl(int[] array)
        {
            int sum = 0;

            foreach (int num in array)
            {
                if (num % 2 != 0) // Проверка на нечетность
                {
                    sum += num;
                }
            }

            return sum;
        }
    }
}