using Tyuiu.ZamyakinaOA.Sprint3.Task2.V18.Lib;

namespace Tyuiu.ZamyakinaOA.Sprint3.Task2.V18.Test
{
    [TestClass]
    public sealed class Test1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Class1 ds = new Class1();
            int value = 1;
            int startValue = 1;
            int stopValue = 14;
            Assert.AreEqual(287.18, ds.GetMultiplySeries(value, startValue, stopValue));
        }
    }
}
