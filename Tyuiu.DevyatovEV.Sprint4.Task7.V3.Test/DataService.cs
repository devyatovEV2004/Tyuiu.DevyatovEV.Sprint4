using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.DevyatovEV.Sprint4.Task7.V3.Lib;

namespace Tyuiu.DevyatovEV.Sprint4.Task7.V3.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();

            int n = 4;
            int m = 2;
            string value = "27182818";

            int result = ds.Calculate(n, m, value);

            // Матрица 4x2 из строки "27182818":
            // 2, 7
            // 1, 8
            // 2, 8
            // 1, 8
            // Нечетные числа: 7, 1, 1
            // Количество нечетных: 3
            int wait = 3;

            Assert.AreEqual(wait, result);
        }

        [TestMethod]
        public void ValidCalculateAllOdd()
        {
            DataService ds = new DataService();

            int n = 2;
            int m = 2;
            string value = "1357";

            int result = ds.Calculate(n, m, value);

            // Все числа нечетные
            int wait = 4;

            Assert.AreEqual(wait, result);
        }

        [TestMethod]
        public void ValidCalculateAllEven()
        {
            DataService ds = new DataService();

            int n = 2;
            int m = 2;
            string value = "2468";

            int result = ds.Calculate(n, m, value);

            // Все числа четные
            int wait = 0;

            Assert.AreEqual(wait, result);
        }
    }
}