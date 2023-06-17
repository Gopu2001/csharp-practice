using Xunit;
using Hello.Services;

namespace Hello.UnitTests.Services
{
    public class HelloService_IsHelloShouldNot
    {
        private readonly HelloService _helloService;
        public HelloService_IsHelloShouldNot()
        {
            _helloService = new HelloService();
        }
        [Theory]
        [InlineData("")]
        [InlineData("H")]
        [InlineData("He")]
        [InlineData("Hel")]
        [InlineData("Hell")]
        public void IsHello_InputIsNotHello_ReturnFalse(string value)
        {
            var result = _helloService.IsHello(value);

            Assert.False(result, $"{value} is not a valid greeting");
        }
        [Theory]
        [InlineData("Hello")]
        [InlineData("HELLO")]
        [InlineData("HeLlO")]
        public void IsHello_InputIsHello_ReturnTrue(string value)
        {
            var result = _helloService.IsHello(value);

            Assert.True(result, "Hello is a valid greeting");
        }
    }
}