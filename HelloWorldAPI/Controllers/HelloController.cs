using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using HelloWorldAPI.Models;

namespace HelloWorldAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HelloController : ControllerBase
    {
        IGreeting _greeting;

        public HelloController(IGreeting Greeting)
        {
            _greeting = Greeting;
        }

        // GET: api/Messages
        [HttpGet]
        public string Get()
        {
            return _greeting.Greeting;
        }
    }
}
