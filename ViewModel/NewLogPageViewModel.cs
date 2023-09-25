using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrekordApp.Model;

namespace TrekordApp.ViewModel
{
    public partial class NewLogPageViewModel : BaseViewModel
    {
        [ObservableProperty]
        [NotifyCanExecuteChangedFor(nameof(SaveCommand))]
        string title;

        [ObservableProperty]
        double latitude;

        [ObservableProperty]
        double longitude;

        [ObservableProperty]
        DateTime date;

        [ObservableProperty]
        int rating;

        [ObservableProperty]
        string entryNotes;

        public bool CanSave() => !string.IsNullOrWhiteSpace(Title);

        public NewLogPageViewModel()
        {
            Date = DateTime.Today;
            Rating = 1;
        }

        [RelayCommand(CanExecute = nameof(CanSave))]
        void Save()
        {
            var newLog = new TrekordLog
            {
                Title = Title,
                Latitude = Latitude,
                Longitude = Longitude,
                Date = Date,
                Rating = Rating,
                EntryNotes = EntryNotes
            };

            //TODO: Add saving of newLog
        }
    }
}
