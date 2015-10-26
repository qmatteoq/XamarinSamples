using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;
using NewsLibrary.Models;
using NewsLibrary.Services;

namespace AndroidSample
{
    [Activity(Label = "AndroidSample", MainLauncher = true, Icon = "@drawable/icon")]
    public class MainActivity : Activity
    {
        protected override async void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);

            string content;
            using (StreamReader sr = new StreamReader(Assets.Open("feed.xml")))
            {
                content = sr.ReadToEnd();
            }

            RssService service = new RssService();
            List<FeedItem> list = await service.GetNews(content);
            
            List<string> items = list.Select(x => x.Title).ToList();

            ListView listView = this.FindViewById<ListView>(Resource.Id.Comics);
            listView.Adapter = new ArrayAdapter<string>(this, Android.Resource.Layout.SimpleListItem1, items);
        }
    }
}

