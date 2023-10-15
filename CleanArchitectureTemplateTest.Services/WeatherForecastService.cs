using CleanArchitectureTemplateTest.Domain.Abstractions;
using CleanArchitectureTemplateTest.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitectureTemplateTest.Services
{
    public class WeatherForecastService : IWeatherForecastServices
    {
        private readonly IWeatherForecastRepository _weatherForecastRepository;

        public WeatherForecastService(IWeatherForecastRepository weatherForecastRepository)
        { 
            _weatherForecastRepository = weatherForecastRepository;
        }

        public List<WeatherForecast> ProcessFTemperature()
        {
            List<WeatherForecast> items = _weatherForecastRepository.GetForecast().ToList();
            List<WeatherForecast> returnItems = new List<WeatherForecast>();
            foreach (var forecast in items) 
            {
                forecast.TemperatureF = 32 + (int)(forecast.TemperatureC / 0.5556);
                returnItems.Add(forecast);
            }
            return items;
        }
    }
}
