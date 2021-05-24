using Newtonsoft.Json;
using System.Net.Http;
using WeatherApp.Model;

namespace WeatherApp.ViewModel
{ //데이터를 실제로 요청하는 부분 
    class WeatherAPI
    {
        public const string API_KEY = "222f006f1c14cc54a6ba117900108ca2";
        public const string BASE_URL = "https://api.openweathermap.org/data/2.5/weather?q={0}&appid={1}";

        public static WeatherInfomation GetweatherInfomation(string cityName)
        {
            WeatherInfomation result = new WeatherInfomation();
            string url = string.Format(BASE_URL, cityName, API_KEY);

            using (HttpClient client = new HttpClient())
            {
                var response = client.GetAsync(url);
                string json = response.Result.Content.ReadAsStringAsync().Result;

                result = JsonConvert.DeserializeObject<WeatherInfomation>(json);
            }
            return result;


        }
    }
}