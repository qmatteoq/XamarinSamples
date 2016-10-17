using Xamarin.Forms;
using MarvelPortable;
using Step3.Helpers;
using MarvelPortable.Model;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.Linq;

#if __ANDROID__
using Xamarin.Forms.Platform.Android;
using Android.Widget;
using Android.Support.Design.Widget;
using Android.Support.V7.View;
using static Android.Support.Design.Widget.AppBarLayout;
#endif

#if WINDOWS_UWP
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Xamarin.Forms.Platform.UWP;
#endif

namespace Step3.Views
{
    public partial class MainView : ContentPage
    {
        private bool isFirstLoad;

        public MainView()
        {
            InitializeComponent();
#if __ANDROID__
            StackLayout layout = new StackLayout
            {
                Padding = 20,
                VerticalOptions = LayoutOptions.End,
                HorizontalOptions = LayoutOptions.End
            };

            FloatingActionButton fab = new FloatingActionButton(Forms.Context);
            fab.Click += (obj, args) =>
            {
                DisplayAlert("Alert", "The button has been clicked", "Ok");
            };
            fab.SetImageResource(Droid.Resource.Drawable.add);

            layout.Children.Add(fab);


            MainStack.Children.Add(layout);
#endif
        }

        protected override async void OnAppearing()
        {
            if (!isFirstLoad)
            {
                IsBusy = true;

                MarvelClient client = new MarvelClient(Constants.ApiKey, Constants.PrivateKey);
                CharacterResponse response = await client.GetCharactersForSeriesAsync(1067);
                IEnumerable<Character> filteredList = response.Results.Where(x => x.Thumbnail != null);
                ObservableCollection<Character> characters = new ObservableCollection<Character>(filteredList);
                CharactersList.ItemsSource = characters;

                IsBusy = false;
                isFirstLoad = true;
            }
        }
    }
}
