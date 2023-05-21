using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace API.Controllers
{
    [Route("weather/[controller]")]
    [ApiController]
    public class historyController : ControllerBase
    {

        private static readonly string[] Summaries = new[]
    {
        "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
    };


        private readonly ILogger<historyController> _logger;

        public historyController(ILogger<historyController> logger)
        {
            _logger = logger;
        }


        // GET api/WeatherHistoryController/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

       
    }
}
