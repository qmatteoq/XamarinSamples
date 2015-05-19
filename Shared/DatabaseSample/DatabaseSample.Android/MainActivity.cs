using System;
using System.Collections.Generic;
using System.Linq;
using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;
using DatabaseSample.PCL;
using DatabaseSample.PCL.Entities;

namespace DatabaseSample.Android
{
    [Activity(Label = "DatabaseSample.Android", MainLauncher = true, Icon = "@drawable/icon")]
    public class MainActivity : Activity
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);

            DatabaseHelper helper = new DatabaseHelper();
            helper.CreateDatabase();

            var nameText = this.FindViewById<EditText>(Resource.Id.NameText);
            var surnameText = this.FindViewById<EditText>(Resource.Id.SurnameText);
            var addButton = this.FindViewById<Button>(Resource.Id.AddButton);
            var getButton = this.FindViewById<Button>(Resource.Id.GetItemsButton);
            var peopleList = this.FindViewById<ListView>(Resource.Id.PeopleList);

            addButton.Click += (sender, args) =>
            {
                Person person = new Person
                {
                    Name = nameText.Text,
                    Surname = surnameText.Text
                };

                helper.Add(person);
            };

            getButton.Click += (sender, args) =>
            {
                List<Person> users = helper.GetUsers();
                var people = users.Select(x => string.Format("{0} {1}", x.Name, x.Surname)).ToList();
                peopleList.Adapter = new ArrayAdapter(this, global::Android.Resource.Layout.SimpleListItem1, people);
            };
        }
    }
}

