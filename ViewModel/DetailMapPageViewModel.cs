using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrekordApp.Model;

namespace TrekordApp.ViewModel
{
    [QueryProperty("LogDetail", "LogDetail")]
    public partial class DetailMapPageViewModel : BaseViewModel
    {
        [ObservableProperty]
        TrekordLog logDetail;

        [ObservableProperty]
        Location pinLocation;

        [ObservableProperty]
        string pinLabel;

        [ObservableProperty]
        ObservableCollection<MapPin> mapPins = new();
        public DetailMapPageViewModel()
        {
            
        }

        [RelayCommand]
        async Task Init()
        {
            var mapPin = new MapPin
            {
                Description = LogDetail.Title,
                Location = new Location
                {
                    Latitude = LogDetail.Latitude,
                    Longitude = LogDetail.Longitude
                }
            };

            if (MapPins.Count > 0)
            {
                MapPins.Clear();
            }

            MapPins.Add(mapPin);
        }
    }

}
