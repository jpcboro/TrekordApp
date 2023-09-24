using Microsoft.Maui.Controls.Maps;
using Microsoft.Maui.Maps;

namespace TrekordApp
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();

            map.MoveToRegion(MapSpan.FromCenterAndRadius(new Location(-37.80403,
            144.97156),
            Distance.FromMiles(0.5)));

            map.Pins.Add(new Pin
            {
                Type = PinType.Place,
                Label = "Royal Exhibition",
                Location = new Location(-37.80403,
                                        144.97156)
            });
        }
    }
}