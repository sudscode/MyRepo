using System;
using System.Collections.Generic;
using Xunit;

namespace SimpleAPI.Tests
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            Assert.Empty(new List<int>());
        }
    }
}
