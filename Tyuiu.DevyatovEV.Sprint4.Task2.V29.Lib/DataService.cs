using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint4;

namespace Tyuiu.DevyatovEV.Sprint4.Task2.V29.Lib
{
    public class DataService : ISprint4Task2V29
    {
        public int Calculate(int[] array)
        {
            int product = 1;
            bool hasEven = false;

            foreach (int num in array)
            {
                if (num % 2 == 0) // Проверка на четность
                {
                    product *= num;
                    hasEven = true;
                }
            }

            // Если четных элементов нет, возвращаем 0
            return hasEven ? product : 0;
        }
    }
}