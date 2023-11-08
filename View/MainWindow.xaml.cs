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
using Microsoft.Toolkit.Wpf.UI.Controls;
using Windows.Devices.Geolocation;
using System.Security.Cryptography;
using Kursach.ViewModel;

namespace Kursach
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            this.DataContext = new MainViewModel();
        }

        private async void MapControl_Loaded(object sender, RoutedEventArgs e)
        {
            var mapControl = sender as MapControl;
            if (mapControl != null)
            {
                BasicGeoposition cityPosition = new BasicGeoposition() { Latitude = 47.604, Longitude = -122.329 };
                var cityCenter = new Geopoint(cityPosition);

                await mapControl.TrySetViewAsync(cityCenter, 12);
            }
        }
    }
}
