using Microsoft.AspNetCore.Mvc;

namespace SimpleWebAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class SimpleController : ControllerBase
    {
        private readonly ILogger<SimpleController> _logger;
        private readonly SomeType _someType;

        public SimpleController(ILogger<SimpleController> logger, SomeType someType)
        {
            _logger = logger;
            _someType = someType;
        }

        [HttpGet(Name = "GetSimpleAPI")]
        public string Get()
        {
            return $"Just some simple string response from SimpleController of instance {_someType.Id}";
        }
    }
}
