using Microsoft.Maui.Controls.Maps;
using Microsoft.Maui.Maps;
using TrekordApp.Model;
using TrekordApp.ViewModel;

namespace TrekordApp.View
{
    public partial class MainPage : ContentPage
    {
        public MainPage(MainPageViewModel vm)
        {
            InitializeComponent();
            BindingContext = vm;
        }
    }
}