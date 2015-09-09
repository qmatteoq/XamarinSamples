using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
            RssService service = new RssService();
            IEnumerable<FeedItem> items = await service.GetNews("http://feeds.feedburner.com/qmatteoq_eng");
            News.ItemsSource = items;
        }

    }
}
