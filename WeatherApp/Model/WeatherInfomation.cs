using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherApp.Model
{
    //받아온 데이터가 WeatherInfomation class 에 파싱되어서 들어가는것 
    public class Main : INotifyPropertyChanged
    {
        private double temp;
        public double Temp
        {
            get { return temp; }
            set { temp = value; OnPropertyChanged("Temp"); }
        }
        private int humidity;
        public int Humidity
        {
            get { return humidity; }
            set { humidity = value; OnPropertyChanged(nameof(Humidity)); }
        }


        public event PropertyChangedEventHandler PropertyChanged;
        private void OnPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }

        public class Wind :INotifyPropertyChanged
    {
        private double speed; 
        public double Speed
        {
            get { return speed; }
            set { speed = value; OnPropertyChanged(nameof(speed)); }
        }
        private int deg;
        public int Deg
        {
            get { return deg; }
            set { deg= value; OnPropertyChanged(nameof(Deg)); }
        }
        public event PropertyChangedEventHandler PropertyChanged;
        private void OnPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }

    }

    public class WeatherInfomation : INotifyPropertyChanged
    {
        public WeatherInfomation()
        {
            Main = new Main()
            {
                Temp = 23,
                Humidity = 10,
            };
            Wind = new Wind()
            {
                Deg = 0,
                Speed = 15,
            };
            Name = "jeonju";
        }

        private Main main;

        public Main Main 
        { 
            get { return main; }
            set { main = value; OnPropertyChanged("Main");}
        }

        private Wind wind;

        public Wind Wind
        {
            get { return wind; }
            set { wind = value; OnPropertyChanged("Wind"); }
        }
        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; OnPropertyChanged("Name"); }

        }


        public event PropertyChangedEventHandler PropertyChanged;
        private void OnPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }

    }
}
