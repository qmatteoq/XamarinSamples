using System;
using System.Linq;
using MarvelPortable.Model;
using Step2.Services;
using Xamarin.Forms;

namespace Step2.Views
{
    public partial class DetailView : TabbedPage
    {
        public DetailView()
        {
            InitializeComponent();
        }

        private void OnShareItem(object sender, EventArgs e)
        {
            Character character = (Application.Current as App).SelectedCharacter;
            IShareService shareService = DependencyService.Get<IShareService>();
            shareService.Share(character.Name, character.Urls.FirstOrDefault().Uri);
        }
    }
}
