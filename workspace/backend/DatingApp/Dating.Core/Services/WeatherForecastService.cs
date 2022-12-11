using Dating.UI;
using Dating.UI.Responses;

namespace Dating.Core.Services;

public class WeatherForecastService
{

    private static readonly string[] Summaries = new[]
    {
        "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
    };


    public async Task<ResponseData<IEnumerable<WeatherForecast>>> GetRandomWeatherForcastsAsync()
    {
        var weatherForcasts = Enumerable.Range(1, 5).Select(index => new WeatherForecast
        {
            Date = DateTime.Now.AddDays(index),
            TemperatureC = Random.Shared.Next(-20, 55),
            Summary = Summaries[Random.Shared.Next(Summaries.Length)]
        });

        return await Task.FromResult(ResponseData.Ok(weatherForcasts));
    }
}
