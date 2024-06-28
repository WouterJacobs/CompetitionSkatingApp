
using CompetitionSkatingApp.Domain;
using CompetitionSkatingApp.Domain.Util;
using CompetitionSkatingApp.Interface.Controls;
using CompetitionSkatingApp.Interface.ViewModels;
using System.Diagnostics;

namespace CompetitionSkatingApp.Interface
{
    public partial class MainPage : ContentPage
    {
        private readonly MainPageViewModel _mainPageViewModel;
        private readonly ICompetitionControlViewModel _competitionControlViewModel;
        public MainPage(MainPageViewModel mainPageViewModel, ICompetitionControlViewModel competitionControlViewModel)
        {
            InitializeComponent();
            _mainPageViewModel = mainPageViewModel;
            BindingContext = _mainPageViewModel; // Set binding context here
            _competitionControlViewModel = competitionControlViewModel;

            // Set the DataContext for CompetitionsControl in the code-behind
            CompetitionsControl competitionsControl = this.FindByName<CompetitionsControl>("CompetitionsControl");
            if (competitionsControl != null)
            {
                competitionsControl.BindingContext = _competitionControlViewModel;
            }
        }

        private async void newEventButton_Clicked(object sender, EventArgs e)
        {
            bool answer = await DisplayAlert("Add new event", "Would you like to add a new event", "Yes", "No");
            if (answer)
            {
                DbWriter dbWriter = new DbWriter();
                dbWriter.MakeNewDatabaseFile("Ritmo Cup");
            }
        }

        private async void loadButton_Clicked(object sender, EventArgs e)
        {
            bool answer = await DisplayAlert("Load event", "Would you like to load an event", "Yes", "No");
        }

        private async void saveButton_Clicked(object sender, EventArgs e)
        {
            bool answer = await DisplayAlert("Save event", "Would you like to save this event", "Yes", "No");
        }

        private async void printButton_Clicked(object sender, EventArgs e)
        {
            bool answer = await DisplayAlert("Print results?", "Would you like print results", "Yes", "No");
        }

        private async void settingsButton_Clicked(object sender, EventArgs e)
        {
            bool answer = await DisplayAlert("Settings?", "Would you like to go to settings", "Yes", "No");
            Debug.WriteLine(answer);
        }
    }

}
