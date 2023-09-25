using TrekordApp.View;

namespace TrekordApp
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();

            Routing.RegisterRoute(nameof(NewLogPage), typeof(NewLogPage));
            Routing.RegisterRoute(nameof(DetailMapPage), typeof(DetailMapPage));
        }
    }
}