using System;
using System.Collections.Generic;
using System.Linq;
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

namespace WeatherClient
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        WeatherServiceReference.WeatherServiceClient _weatherServiceClient =
            new WeatherServiceReference.WeatherServiceClient("NetTcpBinding_IWeatherService");

        public MainWindow()
        {
            InitializeComponent();

            //Наполнение comboBox
            foreach (var item in _weatherServiceClient.GetMainCityList())
                ComboBox.Items.Add(item);

            if (ComboBox.Items.Count != 0)
                ComboBox.SelectedIndex = 0;

        }

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            UpdateData();
        }

        private void TextBlock_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            UpdateData();
            MessageBox.Show("Обновлено");
        }

        private async void UpdateData()
        {
            Load.Visibility = Visibility.Visible;

            string requestCity = ComboBox.SelectedItem.ToString();

            var result = await _weatherServiceClient.GetWeatherDataLastAsync(requestCity);

            UpdateDateTime.Content = $"Обновлено: { result.Date.ToString() }";
            DateForecast.Content = $"Прогноз на: { DateTime.Now.AddHours(18).ToString("dd.MM.yy hh:00") }";
            CityName.Content = requestCity;
            Phenoma.Content = $"{result.Precipitation.ToString().Replace("_", " ")}, {result.Cloudiness.ToString().Replace("_", " ")}";
            Temp.Content = $"Температура воздуха: {result.Temperature} C";
            TempFeel.Content = $"Температура воздуха, по ощущению: {result.TemperatureFeel} C";
            Wind.Content = $"Скорость ветра: {result.Wind} м/с";
            Relwet.Content = $"Влажность воздуха: {result.Humidity} %";
            Pressure.Content = $"Атмосферное давление: {result.Pressure} мм";

            Load.Visibility = Visibility.Hidden;
        }
    }
}
