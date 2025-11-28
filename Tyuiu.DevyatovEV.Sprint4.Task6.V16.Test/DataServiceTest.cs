using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.DevyatovEV.Sprint4.Task6.V16.Lib;

namespace Tyuiu.DevyatovEV.Sprint4.Task6.V16.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();

            string[] array = { "Автомобиль", "Велосипед", "Самолет", "Поезд", "Трамвай", "Троллейбус", "Метро" };

            string[] result = ds.Calculate(array);

            // Элементы длиной 7 символов: "Самолет", "Трамвай", "Троллейбус" (11 символов), "Метро" (5 символов)
            // Проверяем длину каждого слова:
            // "Автомобиль" - 10 символов
            // "Велосипед" - 9 символов  
            // "Самолет" - 7 символов ✓
            // "Поезд" - 6 символов
            // "Трамвай" - 7 символов ✓
            // "Троллейбус" - 10 символов
            // "Метро" - 5 символов
            string[] wait = { "Самолет", "Трамвай" };

            CollectionAssert.AreEqual(wait, result);
        }
    }
}