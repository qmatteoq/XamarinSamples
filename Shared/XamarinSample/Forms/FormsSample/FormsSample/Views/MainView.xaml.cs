using System.Collections.Generic;
using System.IO;
using System.Reflection;
using FormsSample.Services;
using NewsLibrary.Models;
using NewsLibrary.Services;
using Xamarin.Forms;

namespace FormsSample.Views
{
    public partial class MainView : ContentPage
    {
        public MainView()
        {
            InitializeComponent();
        }

        protected override async void OnAppearing()
        {
            var assembly = typeof(App).GetTypeInfo().Assembly;
            Stream stream = assembly.GetManifestResourceStream("FormsSample.feed.xml");
            string text = "";
            using (var reader = new StreamReader(stream))
            {
                text = reader.ReadToEnd();
            }

            RssService service = new RssService();
            IEnumerable<FeedItem> items = await service.GetNews(text);
            News.ItemsSource = items;
        }

        private void News_OnItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            FeedItem item = e.SelectedItem as FeedItem;

            ITextToSpeech textToSpeech = DependencyService.Get<ITextToSpeech>();
            textToSpeech.Speak(item.Title);
        }
    }
}
