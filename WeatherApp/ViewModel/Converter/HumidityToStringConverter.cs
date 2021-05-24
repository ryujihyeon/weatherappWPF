using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;

namespace WeatherApp.ViewModel.Converter
{ //숫자를 높음, 보통, 낮음 으로 바꿔주기 위한  
    public class HumidityToStringConverter : IValueConverter

    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            int humidityValue = (int)value;
            if (humidityValue < 30)
            {
                return "습도 : 낮다";
            }
            if (humidityValue < 40)
            {
                return "습도 : 보통";
            }
            return "습도 : 높음";
        }//습도를 스트링으로 바꿔주는 역할 

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return 0;
        }//스트링을 습도로 바꿔줌  
    }
}
  