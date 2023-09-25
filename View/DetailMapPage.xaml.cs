using CommunityToolkit.Mvvm.Messaging;
using Microsoft.Maui.Controls.Maps;
using Microsoft.Maui.Maps;
using TrekordApp.Model;
using TrekordApp.ViewModel;

namespace TrekordApp.View;

public partial class DetailMapPage : ContentPage
{
    DetailMapPageViewModel viewModel => BindingContext as DetailMapPageViewModel;
    public DetailMapPage(DetailMapPageViewModel vm)
	{
		InitializeComponent();

        BindingContext = vm;
    }

    protected override void OnAppearing()
    {
        base.OnAppearing();

        if (viewModel.LogDetail != null)
        {
            Task.Run(async () =>
            {
                await Task.Delay(1000);
                Device.BeginInvokeOnMainThread(() =>
                {
                    map.MoveToRegion(MapSpan.FromCenterAndRadius(new Location(viewModel.LogDetail.Latitude,
                                     viewModel.LogDetail.Longitude), Distance.FromMiles(0.3)));
                });

            });


        }
    }
}