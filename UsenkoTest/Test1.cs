using UsenkoLib;

namespace UsenkoTest
{
    [TestClass]
    public sealed class Test1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Class1 z1 = new Class1();
            Class2 z2 = new Class2();
            int x = 1;
            int y = 2;
            int a = 3;
            double zf1 = z1.Zfunc1(x, y, a);
            Assert.AreEqual(28, zf1);
            int x2 = 3;
            int y2 = 2;
            int a2 = 1;
            double zf2 = z2.Zfunc2(x2, y2, a2);
            Assert.AreEqual(9, zf2);
        }
    }
}
