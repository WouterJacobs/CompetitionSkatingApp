using System.ComponentModel;

namespace CompetitionSkatingApp.Interface.ViewModels
{
    public interface IViewModel : INotifyPropertyChanged
    {
        Task LoadAsync();
    }
}