using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.DevyatovEV.Sprint4.Task4.V12.Lib;

namespace Tyuiu.DevyatovEV.Sprint4.Task4.V12.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();

            int[,] matrix = new int[5, 5] {
                { 3, 6, 6, 8, 8 },
                { 2, 7, 2, 4, 6 },
                { 3, 6, 2, 6, 4 },
                { 8, 6, 2, 7, 3 },
                { 8, 7, 6, 6, 6 }
            };

            int[,] result = ds.Calculate(matrix);

            // Ожидаемый результат после замены четных на 1:
            int[,] wait = new int[5, 5] {
                { 3, 1, 1, 1, 1 },
                { 1, 7, 1, 1, 1 },
                { 3, 1, 1, 1, 1 },
                { 1, 1, 1, 7, 3 },
                { 1, 7, 1, 1, 1 }
            };

            CollectionAssert.AreEqual(wait, result);
        }
    }
}