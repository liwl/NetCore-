using System;
using Xunit;

namespace 第九章
{
    public class UnitTest1
    {
        [Fact]
        public void PassingTest()
        {
            Assert.Equal(4,Add(2,2));
        }


        [Fact]
        public void FailingTest()
        {
            Assert.Equal(5, Add(2, 2));
        }


        private int Add(int i, int i1)
        {
            return i + i1;
        }
    }
}
