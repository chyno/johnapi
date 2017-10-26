using System;
using Xunit;
using johnapi.Controllers;

namespace tests
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            var cntrl = new ValuesController();
            Assert.NotNull(cntrl);

        }

         [Fact]
        public void Test2()
        {
            var cntrl = new ValuesController();
            Assert.True(1 == 1);

        }

         [Fact]
        public void Test3()
        {
            var cntrl = new ValuesController();
            Assert.True(2 == 6);

        }
    }
}
