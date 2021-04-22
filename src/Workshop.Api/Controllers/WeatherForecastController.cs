using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Workshop.Api.Repositories;

namespace Workshop.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    [Authorize(Roles="Weatherman")]
    public class WeatherForecastController : ControllerBase
    {
        private readonly ILogger<WeatherForecastController> _logger;
        private readonly IWeatherForecastRepository _forecastRepository;

        public WeatherForecastController(IWeatherForecastRepository forecastRepository, ILogger<WeatherForecastController> logger)
        {
            _logger = logger;
            _forecastRepository = forecastRepository;
        }

        [HttpGet]
        public IEnumerable<WeatherForecast> Get()
        {
            return _forecastRepository.Get(5);
        }
    }
}
