using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.KopylskikhVM.Sprint4.Task3.V13.Lib;

namespace Tyuiu.KopylskikhVM.Sprint4.Task3.V13.Test
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
                {4, 7, 4, 2, 1},
                {6, 7, 3, 6, 5},
                {6, 5, 3, 3, 5},
                {4, 4, 6, 4, 7},
                {2, 1, 2, 3, 4}
            };

            int wait = 18;
            int res = ds.Calculate(array);

            Assert.AreEqual(wait, res);
        }
    }
}