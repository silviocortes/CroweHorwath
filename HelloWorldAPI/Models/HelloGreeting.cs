using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HelloWorldAPI.Models
{
    public class HelloGreeting : IGreeting
    {
        public string Greeting => "Hello World";
    }
}
