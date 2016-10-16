using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using MarvelPortable;
using MarvelPortable.Model;
using Xamarin.Forms;
using Step1.Helpers;

namespace Step1.Views
{
    public partial class MainView : ContentPage
    {
        private bool isFirstLoad;

        public MainView()
        {
            InitializeComponent();
        }

        protected override async void OnAppearing()
        {
            if (!isFirstLoad)
            {
                LoadingIndicator.IsRunning = true;

                MarvelClient client = new MarvelClient(Constants.ApiKey, Constants.PrivateKey);
                CharacterResponse response = await client.GetCharactersForSeriesAsync(1067);
                IEnumerable<Character> filteredList = response.Results.Where(x => x.Thumbnail != null);
                ObservableCollection<Character> characters = new ObservableCollection<Character>(filteredList);
                CharactersList.ItemsSource = characters;

                LoadingIndicator.IsRunning = false;
                isFirstLoad = true;
            }
        }

        private async void OnItemTapped(object sender, ItemTappedEventArgs e)
        {
            Character character = e.Item as Character;
            if (character != null)
            {
                ((App)Application.Current).SelectedCharacter = character;

                await Navigation.PushAsync(new DetailView() { Title = character.Name});
            }
        }
    }
}
