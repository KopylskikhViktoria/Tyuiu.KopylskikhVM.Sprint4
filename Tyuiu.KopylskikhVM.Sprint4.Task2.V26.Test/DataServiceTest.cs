using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.KopylskikhVM.Sprint4.Task2.V26.Lib;

namespace Tyuiu.KopylskikhVM.Sprint4.Task2.V26.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();

            int[] array = { 1, 3, 5, 2, 4, 6, 7, 8, 1, 3, 2, 4, 5, 6 };

            int wait = 1575;
            int res = ds.Calculate(array);

            Assert.AreEqual(wait, res);
        }
    }
}