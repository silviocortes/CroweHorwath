using System;
using System.Collections.Generic;
using System.Text;

namespace HelloWorldConsole
{
    public class DBWriter : IWriter
    {
        public void Write(string Message)
        {
            WriteToDB(Message);
        }

        private void WriteToDB(string Message)
        {
            //procedure to write message to DB
            //......
            Console.WriteLine($"Saved \"{Message}\" to DB");
        }
    }
}
