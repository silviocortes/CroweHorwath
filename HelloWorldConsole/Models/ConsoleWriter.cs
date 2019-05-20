using System;
using System.Collections.Generic;
using System.Text;

namespace HelloWorldConsole
{
    public class ConsoleWriter : IWriter
    {
        public void Write(string Message)
        {
            Console.WriteLine(Message);
        }
    }
}
