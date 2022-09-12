using Microsoft.AspNetCore.Mvc;
using ConsoleAppAPI.Controllers;

namespace ConsoleAppAPI.Controllers
{
    [ApiController]
    [Route("test/{action}")]
    public class TestController : ControllerBase
    {
        
        public string Get()
        {
            return "Hello from get method of testcontroller";
        }

        public string Get2()
        {
            return "Hello from get2 method of testcontroller";
        }
    }
}
