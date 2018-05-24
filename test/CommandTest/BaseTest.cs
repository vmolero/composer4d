using System;
using Xunit;
using Command;

namespace CommandTest
{
    public class BaseTest
    {
        [Theoty]
        [InlineData("victor")]
        [InlineData("MJ")]
        public void TestSyHi(string name)
        {
            Base b = new Base();
            Assert.Equal("Hi " + name, b.sayHi(name));
        }
    }
}
