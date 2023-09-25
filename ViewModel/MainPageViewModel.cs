using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using CommunityToolkit.Mvvm.Messaging;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrekordApp.Model;
using TrekordApp.View;

namespace TrekordApp.ViewModel
{
    public partial class MainPageViewModel : BaseViewModel
    {
        [ObservableProperty]
        ObservableCollection<TrekordLog> trekordLogs;

        
        public MainPageViewModel()
        {
            
        }

        [RelayCommand]
        async Task Init()
        {
            TrekordLogs = new()
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
        }

        [RelayCommand]
        async Task NewLog()
        {
            await Shell.Current.GoToAsync($"{nameof(NewLogPage)}", true);
        }

        [RelayCommand]
        async Task TapLog(TrekordLog trekordLog)
        {
            if (trekordLog == null)
                return;

            await Shell.Current.GoToAsync($"{nameof(DetailMapPage)}", true, new Dictionary<string, Object>
            {
                { "LogDetail", trekordLog}
            });
        }
    }
}
