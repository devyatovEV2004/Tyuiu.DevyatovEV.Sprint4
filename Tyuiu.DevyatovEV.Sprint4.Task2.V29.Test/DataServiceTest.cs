using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.DevyatovEV.Sprint4.Task2.V29.Lib;

namespace Tyuiu.DevyatovEV.Sprint4.Task2.V29.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();

            // Тестовый массив с четными элементами
            int[] array = { 2, 4, 3, 5, 6, 7, 8, 1, 4, 2, 3 };

            int result = ds.Calculate(array);

            // Расчет произведения четных элементов:
            // Четные элементы: 2, 4, 6, 8, 4, 2
            // Произведение: 2 * 4 * 6 * 8 * 4 * 2 = 3072
            int wait = 3072;

            Assert.AreEqual(wait, result);
        }

        [TestMethod]
        public void ValidCalculateNoEven()
        {
            DataService ds = new DataService();

            // Тестовый массив без четных элементов
            int[] array = { 1, 3, 5, 7, 1, 3, 5, 7, 1, 3, 5 };

            int result = ds.Calculate(array);

            // Если нет четных элементов, должно вернуть 0
            int wait = 0;

            Assert.AreEqual(wait, result);
        }

        [TestMethod]
        public void ValidCalculateWithOneEven()
        {
            DataService ds = new DataService();

            // Тестовый массив с одним четным элементом
            int[] array = { 1, 3, 5, 7, 2, 3, 5, 7, 1, 3, 5 };

            int result = ds.Calculate(array);

            // Один четный элемент: 2
            int wait = 2;

            Assert.AreEqual(wait, result);
        }
    }
}