using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.DevyatovEV.Sprint4.Task1.V4.Lib;

namespace Tyuiu.DevyatovEV.Sprint4.Task1.V4.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();

            // Тестовый массив: 1, 2, 5, 3, 4, 7, 8, 8, 3, 9
            int[] array = { 1, 2, 5, 3, 4, 7, 8, 8, 3, 9 };

            int result = ds.Calculate(array);

            // Расчет произведения нечетных элементов:
            // Нечетные элементы: 1, 5, 3, 7, 3, 9
            // Произведение: 1 * 5 * 3 * 7 * 3 * 9 = 2835
            int wait = 2835;

            Assert.AreEqual(wait, result);
        }
    }
}