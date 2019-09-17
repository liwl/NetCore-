using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace 第九章_MSTest_
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethodPassing()
        {
            Assert.IsTrue(true);
        }


        [TestMethod]
        public void TestMethodFailing()
        {
            Assert.IsTrue(false);
        }
    }
}
