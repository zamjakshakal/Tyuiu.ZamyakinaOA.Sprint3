using Tyuiu.ZamyakinaOA.Sprint3.Task0.V13.Lib;

namespace Tyuiu.ZamyakinaOA.Sprint3.Task0.V13.Test
{
    [TestClass]
    public sealed class Test1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Class1 ds = new Class1();
            double value = 0.5;
            int startValue = 1;
            int stopValue = 20;
            double res = ds.GetSumSeries(value, startValue, stopValue);
            Assert.AreEqual(0.298, res);
        }
    }
}
