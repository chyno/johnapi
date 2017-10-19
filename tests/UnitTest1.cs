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
    }
}
