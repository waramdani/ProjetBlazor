using BlazorApp1.Data;
using Microsoft.AspNetCore.Components;

namespace BlazorApp1.Pages
{
    public partial class FetchData
    {
        private WeatherForecast[]? forecasts;


        [Inject] WeatherForecastService ForecastService { get; set; }

        protected override async Task OnInitializedAsync()
        {
            forecasts = await ForecastService.GetForecastAsync(DateTime.Now);
        }
    }
}
