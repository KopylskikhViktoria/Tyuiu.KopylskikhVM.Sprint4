using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.KopylskikhVM.Sprint4.Task4.V6.Lib;

namespace Tyuiu.KopylskikhVM.Sprint4.Task4.V6.Test
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
                {7, 6, 6, 6, 9},
                {4, 4, 4, 9, 4},
                {5, 5, 5, 6, 5},
                {4, 9, 5, 9, 7},
                {6, 9, 5, 6, 7}
            };

            int[,] wait = new int[,]
            {
                {0, 6, 6, 6, 0},
                {4, 4, 4, 0, 4},
                {0, 0, 0, 6, 0},
                {4, 0, 0, 0, 0},
                {6, 0, 0, 6, 0}
            };

            int[,] res = ds.Calculate(array);

            CollectionAssert.AreEqual(wait, res);
        }
    }
}