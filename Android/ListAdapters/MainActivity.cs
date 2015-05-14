using System;
using System.Collections.Generic;
using System.Linq;
using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;
using ListAdapters.Helpers;
using MarvelPortable;
using MarvelPortable.Model;

namespace ListAdapters
{
    [Activity(Label = "ListAdapters", MainLauncher = true, Icon = "@drawable/icon")]
    public class MainActivity : Activity
    {

        protected override async void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            SetContentView(Resource.Layout.Main);

            MarvelClient client = new MarvelClient(Constants.ApiKey, Constants.PrivateKey);
            CharacterResponse response = await client.GetCharactersForSeriesAsync(1067);
            List<string> list = response.Results.Select(x => x.Name).ToList();

            ListView listView = this.FindViewById<ListView>(Resource.Id.Comics);
            listView.ItemClick += (sender, args) =>
            {
                string name = list[args.Position];
                var intent = new Intent(this, typeof(DetailActivity));
                intent.PutStringArrayListExtra("character", new string[] {name});
                this.StartActivity(intent);
            };

           
            listView.Adapter = new ArrayAdapter<string>(this, Android.Resource.Layout.SimpleListItem1, list);
        }
    }
}

