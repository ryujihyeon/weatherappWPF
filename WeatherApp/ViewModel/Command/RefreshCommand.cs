using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace WeatherApp.ViewModel.Command
{//ViewModel 이 가지고 있는 Getweather를 통해서 데이터를 요청
    public class RefreshCommand : ICommand
    {
        public WeatherVM VM { get; set; }
        public event EventHandler CanExecuteChanged;

        public RefreshCommand(WeatherVM vm)
        {
            VM = vm;
        }


        public bool CanExecute(object parameter)
        {
            return true; 
        }

        public void Execute(object parameter)
        {
            VM.GetWeather();
        }
    }
}     