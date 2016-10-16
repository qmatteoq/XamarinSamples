using MarvelPortable.Model;
using Xamarin.Forms;

namespace Step2.Views
{
    public partial class DescriptionView : ContentPage
    {
        private Character character;

        public DescriptionView()
        {
            InitializeComponent();
        }

        protected override void OnAppearing()
        {
            character = ((App)Application.Current).SelectedCharacter;
            CharacterDescription.Text = character.Description;
        }
    }
}
