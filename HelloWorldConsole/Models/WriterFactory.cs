using System;
using System.Collections.Generic;
using System.Text;

namespace HelloWorldConsole
{
    static public class WriterFactory
    {
        public static IWriter CreateWriter(string WriterType)
        {
            return (IWriter) Activator.CreateInstance(Type.GetType(WriterType)); ;
        }
    }
}
