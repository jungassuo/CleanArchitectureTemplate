
using CleanArchitectureTemplateTest.Domain.Abstractions;
using CleanArchitectureTemplateTest.Dal;
using CleanArchitectureTemplateTest.Services;

namespace CleanArchitectureTemplateTest.Api
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            builder.Services.AddControllers();
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

            // Add used interfaces and model classes
            // Repository is used as data storage object, which uses IWeatherForecastRepository interface
            // Service is used to calculate F value from C. This service uses IWeatherForecastServices interface

            builder.Services.AddScoped<IWeatherForecastRepository, WeatherForecastRepository>();
            builder.Services.AddScoped<IWeatherForecastServices, WeatherForecastService>();


            var app = builder.Build();
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseHttpsRedirection();

            app.UseAuthorization();


            app.MapControllers();

            app.Run();
        }
    }
}