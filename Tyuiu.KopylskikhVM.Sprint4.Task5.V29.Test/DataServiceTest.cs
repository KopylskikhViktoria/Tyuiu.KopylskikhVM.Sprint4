using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.KopylskikhVM.Sprint4.Task5.V29.Lib;

namespace Tyuiu.KopylskikhVM.Sprint4.Task5.V29.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();

            int[,] array = new int[,]
            {
                { -1, 2, 3, -4, 5 },
                { 0, -2, 6, 7, -8 },
                { 9, -1, 2, -3, 4 },
                { -5, 6, -7, 8, -9 },
                { 1, -2, 3, -4, 5 }
            };

            int wait = 13;
            int res = ds.Calculate(array);

            Assert.AreEqual(wait, res);
        }
    }
}