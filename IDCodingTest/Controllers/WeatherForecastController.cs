using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IDCodingTest.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        private readonly ILogger<WeatherForecastController> _logger;
        private readonly ApplicationContext _cxt;

        public WeatherForecastController(ILogger<WeatherForecastController> logger, ApplicationContext cxt)
        {
            _logger = logger;
            _cxt = cxt;
        }

        [HttpGet]
        public IEnumerable<string> Get()
        {
            var rng = new Random();
            return null;
            //return Enumerable.Range(1, 5).Select(index => new WeatherForecast
            //{
            //    Date = DateTime.Now.AddDays(index),
            //    TemperatureC = rng.Next(-20, 55),
            //    Summary = Summaries[rng.Next(Summaries.Length)]
            //})
            //.ToArray();
            //return _cxt.Region.Select(x => x.regiontype).Distinct().ToArray();

        }
        [HttpGet("/{id}")]
        public IEnumerable<string> GetRegions(int id)
        {
            return _cxt.Region.Select(x => x.regiontype).Distinct().ToArray();

        }
    }
}
