using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.DevyatovEV.Sprint4.Task3.V10.Lib;

namespace Tyuiu.DevyatovEV.Sprint4.Task3.V10.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();

            int[,] array = new int[5, 5] {
                { 5, 7, 6, 6, 5 },
                { 5, 5, 5, 4, 6 },
                { 8, 5, 7, 4, 7 },
                { 7, 6, 7, 4, 7 },
                { 5, 8, 7, 8, 8 }
            };

            int result = ds.Calculate(array);

            // Третья строка (индекс 2): 8, 5, 7, 4, 7
            // Максимальный элемент: 8
            int wait = 8;

            Assert.AreEqual(wait, result);
        }
    }
}