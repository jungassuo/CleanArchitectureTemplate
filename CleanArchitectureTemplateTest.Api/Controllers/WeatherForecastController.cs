using CleanArchitectureTemplateTest.Domain.Abstractions;
using CleanArchitectureTemplateTest.Domain.Models;
using Microsoft.AspNetCore.Mvc;

namespace CleanArchitectureTemplateTest.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {

        private readonly ILogger<WeatherForecastController> _logger;
        private readonly IWeatherForecastServices _services;

        public WeatherForecastController(ILogger<WeatherForecastController> logger, IWeatherForecastServices services)
        {
            _logger = logger;
            _services = services;
        }

        [HttpGet(Name = "GetWeatherForecast")]
        public IEnumerable<WeatherForecast> Get()
        {
            return _services.ProcessFTemperature();
        }
    }
}