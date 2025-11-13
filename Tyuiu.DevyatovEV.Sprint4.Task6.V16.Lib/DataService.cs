using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint4;

namespace Tyuiu.DevyatovEV.Sprint4.Task6.V16.Lib
{
    public class DataService : ISprint4Task6V16
    {
        public string[] Calculate(string[] array)
        {
            // Используем класс Array и метод FindAll для поиска элементов длиной 7 символов
            return Array.FindAll(array, element => element.Length == 7);
        }
    }
}