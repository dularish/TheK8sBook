using Microsoft.AspNetCore.Mvc;

namespace SimpleWebAPIConsumer.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class SimpleConsumerController : ControllerBase
    {
        private readonly ILogger<SimpleConsumerController> _logger;
        private readonly IConfiguration _configuration;

        public SimpleConsumerController(ILogger<SimpleConsumerController> logger, IConfiguration configuration)
        {
            _logger = logger;
            _configuration = configuration;
        }

        [HttpGet(Name = "GetSimpleWebAPICall")]
        public async Task<string> Get()
        {
            try
            {
                //Calls API from SimpleController and returns the response
                var baseUrl = _configuration["ServiceBaseUrl"];
                var url = $"{baseUrl}/Simple";
                //Call the API
                using var client = new HttpClient();
                var response = await client.GetStringAsync(url);

                return $"Response from producer : {response}";
            }
            catch (Exception ex)
            {
                return $"Exception found : {ex.Message}; {ex.StackTrace}";
            }
        }
    }
}
