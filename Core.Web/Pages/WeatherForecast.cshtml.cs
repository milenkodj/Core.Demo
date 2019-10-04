using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core.Domain;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Core.Web.Pages
{
    public class WeatherForecastModel : PageModel
    {

        public List<WeatherForecast> WeatherForecasts = null;
        public void OnGet()
        {
            WeatherForecasts = Enumerable.Range(1, 5)
                .Select(index => WeatherForecast.GetWeatherForectast(index))
                .ToList();
        }
    }
}