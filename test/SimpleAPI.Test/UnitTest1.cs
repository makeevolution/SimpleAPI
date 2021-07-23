using System;
using Xunit;
using SimpleAPI.Controllers;

namespace SimpleAPI.Test
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            string returnValue = HomeController.Get();
            Assert.Equal("Les Jackson", returnValue);
        }
    }
}
