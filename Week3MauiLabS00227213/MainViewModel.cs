using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Plugin.Maui.Audio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week3MauiLabS00227213

{
    public partial class MainViewModel : ObservableObject
    {
        public IAudioManager AudioManager { get; set; }
        public IAudioPlayer AudioPlayer { get; set; }

        public MainViewModel(IAudioManager audioManager)
        {
            AudioManager = audioManager;
        }

        [ObservableProperty]
        List<string> soundNames = new List<string>() { "0.wav", "1.wav", "Puccini Nessun Dorma.mp3", "29.wav" };

        [RelayCommand]
        public void PlaySound(string Sound)
        {
            System.IO.Stream s = Task.Run(() => FileSystem.OpenAppPackageFileAsync(Sound)).Result;
            AudioPlayer = AudioManager.CreatePlayer(s);
            AudioPlayer.Play();
        }

        // Added a method to play the Puccini Nessun Dorma.mp3
        [RelayCommand]
        public void PlayPuccini()
        {
            PlaySound("Puccini Nessun Dorma.mp3");
        }

        // Added a method to play the 29.wav
        [RelayCommand]
        public void Play29Wav()
        {
            PlaySound("29.wav");
        }
    }
}
