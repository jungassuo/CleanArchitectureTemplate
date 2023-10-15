using CleanArchitectureTemplateTest.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitectureTemplateTest.Domain.Abstractions
{
    public interface IWeatherForecastServices
    {
        List<WeatherForecast> ProcessFTemperature();
    }
}
