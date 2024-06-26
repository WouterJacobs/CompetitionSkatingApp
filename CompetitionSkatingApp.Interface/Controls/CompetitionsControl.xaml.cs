using CompetitionSkatingApp.Interface.ViewModels;

namespace CompetitionSkatingApp.Interface.Controls;

public partial class CompetitionsControl : ContentView
{
    ICompetitionControlViewModel _competitionControlViewModel;

    public CompetitionsControl(ICompetitionControlViewModel competitionControlViewModel)
	{
		InitializeComponent();
        _competitionControlViewModel = competitionControlViewModel;
        BindingContext = _competitionControlViewModel;

    }
    public CompetitionsControl()
    {
        InitializeComponent();
    }

    private async void Button_Clicked(object sender, EventArgs e)
    {
         await App.Current.MainPage.DisplayAlert("test", "Would you like to add a new event", "Yes", "No");

    }
}