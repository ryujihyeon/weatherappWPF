using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WeatherApp.Model;
using WeatherApp.ViewModel.Command;

namespace WeatherApp.ViewModel
{ // 가장 상위 에서 프로그램 전체적인 제어를 하는 역할, WeatherAPI여기서 호출 
    public class WeatherVM
    {
        public WeatherInfomation Weather { get; set; }
        public ObservableCollection<string> Cities { get; set; } // 사용자가 날씨를 알고싶은 도시들의 정보를 가지고 있음

        private string selectedCity;

        public string SelectedCity
        {
            get { return selectedCity;}
            set { selectedCity = value; GetWeather(); }
        }
        public RefreshCommand RefreshCommand { get; set; }
        public WeatherVM()
        {
            Weather= new WeatherInfomation(); // 
            Cities = new ObservableCollection<string>();

            Cities.Add("London");
            Cities.Add("jeonju");
            Cities.Add("Paris");
            Cities.Add("seoul");

            RefreshCommand = new RefreshCommand(this); //viewmodel 객채 하나를 참조해서 넘겨줘 , command 객체가 뷰모델의 참조를 가지게됨



        }
        public void GetWeather()
        {
            if (selectedCity != null)
            {
                var weather = WeatherAPI.GetweatherInfomation(SelectedCity);
                Weather.Name = weather.Name;
                Weather.Main = weather.Main;
                Weather.Wind = weather.Wind;
            }
        }

    }
}