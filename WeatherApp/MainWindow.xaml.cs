using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WeatherApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private WeatherInfo weather = new WeatherInfo();

        public MainWindow()
        {
            InitializeComponent();
        }

        private void updateClick(object sender, RoutedEventArgs e)
        {
            var url = $"https://api.openweathermap.org/data/2.5/forecast?q={cityTB.Text}&units=metric&appid=9176f39c6ae3eb96104eb48077805a7a&cnt=5";

            using (WebClient client = new WebClient())
            {
                var json = client.DownloadString(url);
                weather = JsonConvert.DeserializeObject<WeatherInfo>(json);
            }
            dataGrid.ItemsSource = weather.List;
        }

        private void cityTB_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
