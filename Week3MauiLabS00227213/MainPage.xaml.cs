using CommunityToolkit.Mvvm.Input;
using Plugin.Maui.Audio;
using Microsoft.Maui.Controls;
using System;
using Week3MauiLabS00227213;
namespace Week3MauiLabS00227213
{
    public partial class MainPage : ContentPage
    {
        int count = 0;
        public MainViewModel ViewModel { get; set; }

        public MainPage(IAudioManager audioManager)
        {
            InitializeComponent();

            // Initialize ViewModel
            ViewModel = new MainViewModel(audioManager);
            BindingContext = ViewModel;  // set binding context to ViewModel
        }

        private void OnCounterClicked(object sender, EventArgs e)
        {
            count++;

            if (count == 1)
                CounterBtn.Text = $"Clicked {count} time";
            else
                CounterBtn.Text = $"Clicked {count} times";

            SemanticScreenReader.Announce(CounterBtn.Text);
        }

        private void OnPlayPucciniClicked(object sender, EventArgs e)
        {
            ViewModel.PlayPuccini();
        }

        private void OnPlay29WavClicked(object sender, EventArgs e)
        {
            ViewModel.Play29Wav();
        }
    }
}
