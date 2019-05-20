using System;
using Xunit;
using HelloWorldAPI.Controllers;
using HelloWorldAPI.Models;

namespace HelloWorldAPI.Tests
{
    public class HelloControllerTest
    {
        [Fact]
        public void GetTest()
        {
            //arrange
            string expectedGreeting = "Hello World";

            //act
            HelloController hc = new HelloController(new HelloGreeting());

            //asset
            Assert.Equal(expectedGreeting, hc.Get());
        }
    }
}
