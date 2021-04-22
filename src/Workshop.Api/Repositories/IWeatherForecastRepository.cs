using System.Collections.Generic;

namespace Workshop.Api.Repositories
{
    public interface IWeatherForecastRepository
    {
        IEnumerable<WeatherForecast> Get(int count);
    }
}
