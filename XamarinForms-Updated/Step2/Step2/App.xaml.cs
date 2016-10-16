using MarvelPortable.Model;
using Step2.Views;
using Xamarin.Forms;

namespace Step2
{
    public partial class App : Application
    {
        public Character SelectedCharacter { get; set; }

        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new MainView());
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
