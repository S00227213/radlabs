using Week5_Sample_code.Pages;
using System;

namespace Week5_Sample_code
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            Routing.RegisterRoute(nameof(MainPage), typeof(MainPage));
            Routing.RegisterRoute(nameof(ToggleConentViewPage), typeof(ToggleConentViewPage));
            InitializeComponent();
        }
    }
}