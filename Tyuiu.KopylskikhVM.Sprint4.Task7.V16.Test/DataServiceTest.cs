using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.KopylskikhVM.Sprint4.Task7.V16.Lib;

namespace Tyuiu.KopylskikhVM.Sprint4.Task7.V16.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();

            int n = 5;
            int m = 3;
            string value = "382976421897948";

            int wait = 196608;
            int res = ds.Calculate(n, m, value);

            Assert.AreEqual(wait, res);
        }
    }
}