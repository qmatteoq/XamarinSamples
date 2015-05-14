using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace ListAdapters
{
    [Activity(Label = "DetailActivity")]
    public class DetailActivity : Activity
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            SetContentView(Resource.Layout.Detail);

            IList<string> names = this.Intent.Extras.GetStringArrayList("character");

            TextView characterTextView = this.FindViewById<TextView>(Resource.Id.CharacterName);
            characterTextView.Text = names[0];
        }
    }
}