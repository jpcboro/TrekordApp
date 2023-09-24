using Microsoft.Maui.Controls.Maps;
using Microsoft.Maui.Maps;
using TrekordApp.Model;

namespace TrekordApp.View;

public partial class DetailMapPage : ContentPage
{
	public DetailMapPage(TrekordLog log)
	{
		InitializeComponent();

        map.MoveToRegion(MapSpan.FromCenterAndRadius(new Location(log.Latitude,
            log.Longitude),
            Distance.FromMiles(0.5)));

        map.Pins.Add(new Pin
        {
            Type = PinType.Place,
            Label = log.Title,
            Location = new Location(log.Latitude,
                                    log.Longitude)
        });
    }
}