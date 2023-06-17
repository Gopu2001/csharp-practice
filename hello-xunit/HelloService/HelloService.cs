using System;

namespace Hello.Services
{
    public class HelloService
    {
        public bool IsHello(string message)
        {
            // throw new NotImplementedException("Not implemented.");
            if (message.ToUpper() != "HELLO") {
                return false;
            }
            return true;
        }
    }
}