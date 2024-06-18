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
}