using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using VA.Argument.Extensions;

namespace DempApp.Controllers
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

        public WeatherForecastController(ILogger<WeatherForecastController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IEnumerable<WeatherForecast> Get()
        {
            var rng = new Random();
            return Enumerable.Range(1, 5).Select(index => new WeatherForecast
            {
                Date = DateTime.Now.AddDays(index),
                TemperatureC = rng.Next(-20, 55),
                Summary = Summaries[rng.Next(Summaries.Length)]
            })
            .ToArray();
        }

        [HttpGet("ThrowIfOutOfLength")]
        public IActionResult ThrowIfOutOfLength()
        {
            string myName = "Vinay";
            myName.ThrowIfOutOfLength(7, 10, nameof(myName));

            var input = "";
            input.ThrowIfNullOrEmpty(nameof(input));
            return Ok();
        }

        [HttpGet("ThrowIfNull")]
        public IActionResult ThrowIfNull()
        {
            string value = null;
            value.ThrowIfNull(nameof(value));

            return Ok(value.ToArray());
        }
    }
}
