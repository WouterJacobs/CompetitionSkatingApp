
namespace CompetitionSkatingApp.Interface
{
    public partial class MainPage : ContentPage
    {

        public MainPage()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
             DisplayAlert("New", "Making a new competition\nare you sure?", "Cancel");
        }
    }

}
