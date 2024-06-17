
using CompetitionSkatingApp.Interface.ViewModels;
using System.Diagnostics;

namespace CompetitionSkatingApp.Interface
{
    public partial class MainPage : ContentPage
    {
        private readonly MainPageViewModel _mainPageViewModel;

        public MainPage(MainPageViewModel mainPageViewModel)
        {
            InitializeComponent();
            _mainPageViewModel = mainPageViewModel;
            BindingContext = _mainPageViewModel; // Set binding context here
        }

        private void newEventButton_Clicked(object sender, EventArgs e)
        {
            DisplayAlert("Add new event", "Would you like to add a new event", "Yes", "No");
        }

        private void loadButton_Clicked(object sender, EventArgs e)
        {
            DisplayAlert("Load event", "Would you like to load an event", "Yes", "No");
        }

        private void saveButton_Clicked(object sender, EventArgs e)
        {
            DisplayAlert("Save event", "Would you like to save this event", "Yes", "No");
        }

        private void printButton_Clicked(object sender, EventArgs e)
        {
            DisplayAlert("Print results?", "Would you like print results", "Yes", "No");
        }

        private async void settingsButton_Clicked(object sender, EventArgs e)
        {
            bool answer = await DisplayAlert("Settings?", "Would you like to go to settings", "Yes", "No");
            Debug.WriteLine(answer);
        }
    }

}
