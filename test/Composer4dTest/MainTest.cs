using System;
using Xunit;
using Composer4d;

namespace Composer4dTest
{
    public class MainTest
    {
        [Theory]
        [InlineData("--proj", "file.dproj")]
        public void Test1(string arg0, string arg1)
        {
            Assert.True(false);
        }
    }
}
