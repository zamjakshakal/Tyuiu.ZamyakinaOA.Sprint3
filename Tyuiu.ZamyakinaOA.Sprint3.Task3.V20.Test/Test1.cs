using Tyuiu.ZamyakinaOA.Sprint3.Task3.V20.Lib;

namespace Tyuiu.ZamyakinaOA.Sprint3.Task3.V20.Test
{
    [TestClass]
    public sealed class Test1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Class1 ds = new Class1();
            string value = "gfft ntf f opf";
            char item = 'f';
            Assert.AreEqual(5, ds.GetCharCount(value, item));
        }
    }
}
