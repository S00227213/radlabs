using CommunityToolkit.Mvvm.ComponentModel;
using Plugin.Maui.Audio;
using System.Collections.Generic;
using System;

namespace Week3MauiLabS00227213.ViewModels
{
    public partial class MainViewModel : ObservableObject
    {
        public IAudioManager AudioManager { get; set; }

        public MainViewModel(IAudioManager audioManager)
        {
            AudioManager = audioManager;
        }

        public async void PlaySound(string Sound)
        {
            try
            {
                System.IO.Stream s = await FileSystem.OpenAppPackageFileAsync(Sound);
                var audioPlayer = AudioManager.CreatePlayer(s);
                audioPlayer.Play();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error playing sound: {ex.Message}");
            }
        }
    }
}
