using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.DevyatovEV.Sprint4.Task5.V25.Lib;

namespace Tyuiu.DevyatovEV.Sprint4.Task5.V25.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();

            // Тестовый массив с положительными и отрицательными элементами
            int[,] matrix = new int[5, 5] {
                { -3,  2, -1,  0,  3 },
                { -4,  1, -2,  2, -3 },
                {  0, -1,  3, -4,  1 },
                {  2, -2,  1,  0, -1 },
                { -3,  3, -4,  2,  0 }
            };

            int result = ds.Calculate(matrix);

            // Расчет суммы положительных элементов:
            // Положительные: 2, 3, 1, 2, 3, 1, 2, 3, 2
            // Сумма: 2 + 3 + 1 + 2 + 3 + 1 + 2 + 3 + 2 = 19
            int wait = 19;

            Assert.AreEqual(wait, result);
        }

        [TestMethod]
        public void ValidCalculateNoPositive()
        {
            DataService ds = new DataService();

            // Тестовый массив без положительных элементов
            int[,] matrix = new int[5, 5] {
                { -3, -2, -1,  0, -3 },
                { -4, -1, -2, -2, -3 },
                {  0, -1, -3, -4, -1 },
                { -2, -2, -1,  0, -1 },
                { -3, -3, -4, -2,  0 }
            };

            int result = ds.Calculate(matrix);

            // Если нет положительных элементов, должно вернуть 0
            int wait = 0;

            Assert.AreEqual(wait, result);
        }

        [TestMethod]
        public void ValidCalculateAllPositive()
        {
            DataService ds = new DataService();

            // Тестовый массив со всеми положительными элементами
            int[,] matrix = new int[5, 5] {
                { 1, 2, 1, 3, 2 },
                { 2, 1, 3, 2, 1 },
                { 3, 2, 1, 3, 2 },
                { 1, 3, 2, 1, 3 },
                { 2, 1, 3, 2, 1 }
            };

            int result = ds.Calculate(matrix);

            // Сумма всех элементов (все положительные)
            int wait = 1 + 2 + 1 + 3 + 2 + 2 + 1 + 3 + 2 + 1 + 3 + 2 + 1 + 3 + 2 + 1 + 3 + 2 + 1 + 3 + 2 + 1 + 3 + 2 + 1;

            Assert.AreEqual(wait, result);
        }
    }
}