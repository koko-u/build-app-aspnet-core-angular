using Dating.Config;
using Dating.Core.Services;
using Dating.UI;
using Dating.UI.Responses;
using Microsoft.AspNetCore.Mvc;

namespace Dating.Api.Controllers;

[ApiController]
[Route("api/[controller]")]
public class WeatherForecastController : ControllerBase
{
    private readonly ILogger<WeatherForecastController> _logger;
    private readonly WeatherForecastService _weatherForecastService;

    public WeatherForecastController(ILogger<WeatherForecastController> logger,
                                     WeatherForecastService weatherForecastService)
    {
        _weatherForecastService = weatherForecastService;
        _logger = logger;
    }

    [HttpGet(Name = "GetWeatherForecast")]
    public async Task<ResponseData<IEnumerable<WeatherForecast>>> Get()
    {
        var response = await _weatherForecastService.GetRandomWeatherForcastsAsync();

        return response;
    }
}
