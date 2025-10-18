using Tyuiu.ZamyakinaOA.Sprint3.Task1.V15.Lib;

namespace Tyuiu.ZamyakinaOA.Sprint3.Task1.V15.Test
{
    [TestClass]
    public sealed class Test1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Class1 ds = new Class1();
            int value = 2;
            int startValue = 1;
            int stopValue = 5;
            double res = ds.GetMultiplySeries(value, startValue, stopValue);
            Assert.AreEqual(66, res);
        }
    }
}
