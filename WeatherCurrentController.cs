using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace API.Controllers
{
    [Route("weather/[controller]")]
    [ApiController]
    public class currentController : ControllerBase
    {

        private static readonly string[] Summaries = new[]
       {
        "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
    };

        private static readonly string[] Location = new[]
      {
        "London", "Paris", "New York", "Los Angeles", "Berlin", "Sarajevo", "Beograd", "Zagreb", "Madrid", "Rome"
    };



        private readonly ILogger<currentController> _logger;

        public currentController(ILogger<currentController> logger)
        {
            _logger = logger;
        }

       
        // GET api/WeatherCurrentController/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

       
    }
}
