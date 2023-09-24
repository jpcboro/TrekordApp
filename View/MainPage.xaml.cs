using Microsoft.Maui.Controls.Maps;
using Microsoft.Maui.Maps;
using TrekordApp.Model;

namespace TrekordApp.View
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();

            //map.MoveToRegion(MapSpan.FromCenterAndRadius(new Location(-37.80403,
            //144.97156),
            //Distance.FromMiles(0.5)));

            //map.Pins.Add(new Pin
            //{
            //    Type = PinType.Place,
            //    Label = "Royal Exhibition",
            //    Location = new Location(-37.80403,
            //                            144.97156)
            //});

            var items = new List<TrekordLog>()
        {
            new TrekordLog
            {
                Title = "State Library Victoria",
                EntryNotes = "Nice place to read and relax!",
                Rating = 5,
                Date = new DateTime(2023, 09,20),
                Latitude = -37.809811,
                Longitude = 144.965195
            },
            new TrekordLog
            {
                Title = "Flinders St Station",
                EntryNotes = "Very busy place but nice architecture",
                Rating = 3,
                Date = new DateTime(2023, 07,15),
                Latitude = -37.8183,
                Longitude = 144.9671
            },
            new TrekordLog
            {
                Title = "Royal Exhibition Building",
                EntryNotes = "Building,architecture, and gardens are fab",
                Rating = 4,
                Date = new DateTime(2023, 06,10),
                Latitude = -37.80403,
                Longitude = 144.97156
            }
        };

            trekLogs.ItemsSource = items;
        }

        private async void ToolbarItem_Clicked(object sender, EventArgs e)
        {
            await Shell.Current.Navigation.PushAsync(new NewLogPage());
        }

        private async void logs_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var log = (TrekordLog)e.CurrentSelection.FirstOrDefault();

            if (log != null)
            {
                await Shell.Current.Navigation.PushAsync(new DetailMapPage(log));
            }

            trekLogs.SelectedItem = null;
        }
    }
}