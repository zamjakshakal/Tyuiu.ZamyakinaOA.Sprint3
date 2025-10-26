using Tyuiu.ZamyakinaOA.Sprint3.Task7.V27.Lib;

namespace Tyuiu.ZamyakinaOA.Sprint3.Task7.V27.Test
{
    [TestClass]
    public sealed class Test1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Class1 ds = new Class1();
            int startValue = -5;
            int stopValue = 5;

            int len = stopValue - startValue + 1;

            double[] valueWaitArray;
            valueWaitArray = new double[len];

            valueWaitArray[0] = 0;
            valueWaitArray[1] = 0;
            valueWaitArray[2] = 0;
            valueWaitArray[3] = 0;
            valueWaitArray[4] = 0;
            valueWaitArray[5] = 0;
            valueWaitArray[6] = 0;
            valueWaitArray[7] = 0;
            valueWaitArray[8] = 0;
            valueWaitArray[9] = 0;
            valueWaitArray[10] = 0;

            double[] res;
            res = new double[len];
            res = ds.GetMassFunction(startValue, stopValue);
            CollectionAssert.AreEqual(valueWaitArray, res);
        }
    }
}
