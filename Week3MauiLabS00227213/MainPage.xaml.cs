using Microsoft.Maui.Controls;
using Plugin.Maui.Audio;
using Week3MauiLabS00227213.ViewModels;
using System;

namespace Week3MauiLabS00227213
{
    public partial class MainPage : ContentPage
    {
        int count = 0;
        MainViewModel viewModel;

        public MainPage(IAudioManager audioManager)
        {
            InitializeComponent();
            viewModel = new MainViewModel(audioManager);
            this.BindingContext = viewModel;
        }

        private void OnCounterClicked(object sender, EventArgs e)
        {
            count++;
            CounterBtn.Text = count == 1 ? $"Clicked {count} time" : $"Clicked {count} times";
            viewModel.PlaySound("Resources/Raw/sound_29.wav");
        }
    }
}
