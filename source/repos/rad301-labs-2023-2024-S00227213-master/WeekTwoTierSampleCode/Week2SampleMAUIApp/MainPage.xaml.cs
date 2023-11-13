using Plugin.Maui.Audio;
using Week2SampleMAUIApp.ViewModels;

namespace Week2SampleMAUIApp
{
    public partial class MainPage : ContentPage
    {
        int count = 0;
        MainViewModel MainViewModel;
        public MainPage(IAudioManager audioManager)
        {
            MainViewModel = new MainViewModel(audioManager);
            BindingContext = MainViewModel;
            InitializeComponent();
        }

        protected override void OnAppearing()
        {
            MainViewModel.PlaySound("backing track.mp3");
            base.OnAppearing();
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
    }
}