using System;
using System.Collections.Generic;
using System.Linq;
using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;
using CustomListAdapter.Helpers;
using MarvelPortable;
using MarvelPortable.Model;

namespace CustomListAdapter
{
    [Activity(Label = "CustomListAdapter", MainLauncher = true, Icon = "@drawable/icon")]
    public class MainActivity : Activity
    {
        protected override async void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);

            MarvelClient client = new MarvelClient(Constants.ApiKey, Constants.PrivateKey);
            CharacterResponse response = await client.GetCharactersForSeriesAsync(1067);
            List<Character> list = response.Results.ToList();

            ListView listViewComics = this.FindViewById<ListView>(Resource.Id.Comics);
            listViewComics.Adapter = new CharacterAdapter(this, list);
        }
    }
}

