using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.DevyatovEV.Sprint4.Task5.V25.Lib;

namespace Tyuiu.DevyatovEV.Sprint4.Task5.V25.Test
{
    [TestClass]
    public class DataServiceTest
    {
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