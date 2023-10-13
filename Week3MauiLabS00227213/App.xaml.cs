using Microsoft.Maui;
using Microsoft.Maui.Controls;
using Plugin.Maui.Audio;
using Microsoft.Extensions.DependencyInjection;

namespace Week3MauiLabS00227213
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
            var audioManager = MauiProgram.AppInstance.Services.GetRequiredService<IAudioManager>();
            MainPage = new MainPage(audioManager);
        }
    }
}
