using AllForOneBack.Controllers;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using AllForOneBack.Services;

namespace AllForOneBack.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class SayHelloController : ControllerBase
    {
        private readonly SayHelloService _sayHelloService;
        public SayHelloController(SayHelloService sayHelloService)
        {
            _sayHelloService = sayHelloService;
        }
        [HttpGet]
        [Route("SayHello/{name}")]

        public string SayHello(string name)
        {
            return _sayHelloService.AddName(name);
        }
}

}
