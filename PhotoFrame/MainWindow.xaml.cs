using System;
using System.Windows;
using System.Windows.Media.Imaging;
using System.Windows.Threading;
using System.IO;
using System.Collections.ObjectModel;

namespace PhotoFrame
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        DispatcherTimer TimerClock = new DispatcherTimer();
        DispatcherTimer TimerImage = new DispatcherTimer();

        public class ImageEventArgs : EventArgs
        {
            public SlideShow slideShowArg { get; set; }
        }


        public MainWindow()
        {
            InitializeComponent();

            //poveži se na weather api - trenutno vrijeme
            RestClient restClient = new RestClient();
            restClient.EndPoint = "http://api.openweathermap.org/data/2.5/weather?q=Zagreb,HR&units=metric&appid=afd75004902d6b7f60f880ff6322266f&lang=hr";
            string strResponse = restClient.MakeRequest();


            //Učitaj podatke lokalno
            WeatherData weatherData = new WeatherData();
            weatherData.PopulateProperties(strResponse);
            //
            //

            //prikaži dan, datum i sat
            txtDay.Text = DateTime.Now.ToString("dddd").ToUpper();
            txtDate.Text = DateTime.Now.ToString("dd.MM.yy");

            TimerClock.Tick += new EventHandler(OnSecondChanged);
            TimerClock.Interval = new TimeSpan(0, 0, 1);
            TimerClock.Start();
            //txtTime.Text = DateTime.Now.ToString("hh:mm:ss");
            //

            //uključi slideshow            
            SlideShow slideShow = new SlideShow();
            slideShow.DirPath = @"C:\Users\mile.mrkobrad\Documents\visual studio 2017\Projects\PhotoFrame\PhotoFrame\Resources";
            try
            {
                slideShow.CreateList();

                TimerImage.Tick += new EventHandler((sender, e) => OnImageSpan(sender, e, new ImageEventArgs { slideShowArg = slideShow }));
                TimerImage.Interval = new TimeSpan(0, 0, 3);
                TimerImage.Start();
            }
            catch (Exception ex)
            {
                txtStatus.Text = "Greška: " + ex.Message;
            }
            //

            //forecast
            //poveži se na weather api - trenutno vrijeme
            RestClient restClientF = new RestClient();
            restClientF.EndPoint = "http://api.openweathermap.org/data/2.5/forecast?q=Zagreb,HR&units=metric&appid=afd75004902d6b7f60f880ff6322266f&lang=hr";
            string strResponseF = restClientF.MakeRequest();

            WeatherData weatherDataForecast = new WeatherData();
            ObservableCollection<WeatherData> forecast = new ObservableCollection<WeatherData>();
            forecast = weatherDataForecast.PopulatePropertiesForecast(strResponseF);
            //

            DataContext = new
            {
                weatherData,
                forecast
            };

        }

        private void OnSecondChanged(object sender, EventArgs e)
        {
            DateTime d = DateTime.Now;
            txtTime.Text = d.ToString("HH:mm");
        }

        private void OnImageSpan(object sender, EventArgs e, ImageEventArgs slideShowArg)
        {
            string argPath = slideShowArg.slideShowArg.GetNextImage();

            if (File.Exists(argPath))
            {
                BitmapImage image = new BitmapImage();
                image.BeginInit();
                image.UriSource = new Uri(argPath);
                image.EndInit();

                imgPhoto.Source = image;
            }
        }

        private void btnClose_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
