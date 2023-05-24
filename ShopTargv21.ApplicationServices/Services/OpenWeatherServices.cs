using Nancy.Json;
using ShopTARgv21.Core.Dto.OpenWeather;
using ShopTARgv21.Core.ServiceInterface;
using System.Net;


namespace ShopTARgv21.ApplicationServices.Services
{
    public class OpenWeatherServices : IOpenWeatherServices
    {
        public async Task<OpenWeatherResultDto> OpenWeatherDetail(OpenWeatherResultDto dto)
        {
            var url = $"https://api.openweathermap.org/data/2.5/weather?q=London,uk&APPID=0695ebcdb67188fce27ca4c5abd5f934";
            //var url2 = $"https://api.openweathermap.org/data/2.5/weather?q=London,uk&APPID={apiKey}";

            using (WebClient client = new WebClient())
            {
                string json = client.DownloadString(url);
                Root weatherInfo = (new JavaScriptSerializer()).Deserialize<Root>(json);

                dto.temp = weatherInfo.main.temp;

                dto.pressure = weatherInfo.main.pressure;

                dto.humidity = weatherInfo.main.humidity;

                dto.feels_like = weatherInfo.main.feels_like;

                dto.speed = weatherInfo.wind.speed;

                dto.main = weatherInfo.weather[0].main;
                

                var jsonString = new JavaScriptSerializer().Serialize(dto);
            }
            return dto;
        }
    }
}
