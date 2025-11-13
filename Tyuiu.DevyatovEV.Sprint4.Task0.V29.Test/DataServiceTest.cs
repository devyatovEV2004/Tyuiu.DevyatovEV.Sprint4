using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.DevyatovEV.Sprint4.Task0.V29.Lib;

namespace Tyuiu.DevyatovEV.Sprint4.Task0.V29.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidGetSumOddArrEl()
        {
            DataService ds = new DataService();

            int[] array = { 7, 4, 3, 2, 1, 5, 9, 8, 7, 4 };

            int result = ds.GetSumOddArrEl(array);

            int wait = 32;

            Assert.AreEqual(wait, result);
        }
    }
}