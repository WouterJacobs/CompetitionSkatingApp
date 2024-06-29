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
    protected override void OnBindingContextChanged()
    {
        base.OnBindingContextChanged();
        _competitionControlViewModel = BindingContext as ICompetitionControlViewModel;
    }

    private async void Button_Clicked(object sender, EventArgs e)
    {
        bool answer = await App.Current.MainPage.DisplayAlert("test", "clicking a competition", "Yes", "No");

    }

    private async void AddCompetionButton_Clicked(object sender, EventArgs e)
    {
        bool answer = await App.Current.MainPage.DisplayAlert("Adding Competition", "Do you want to add a Competition", "Yes", "No");
    }
}