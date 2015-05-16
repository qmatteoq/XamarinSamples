using System;
using Android.App;
using Android.Content;
using Android.Content.PM;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;

namespace ActivityState
{
	[Activity(Label = "ActivityState", MainLauncher = true, Icon = "@drawable/icon")]
	public class MainActivity : Activity
	{
		int count = 1;

		protected override void OnCreate(Bundle bundle)
		{
			base.OnCreate(bundle);

			SetContentView(Resource.Layout.Main);

			Button button = FindViewById<Button>(Resource.Id.MyButton);
			button.Click += delegate { button.Text = string.Format("{0} clicks!", count++); };

            //Restore instance state (if available)
            if (bundle != null)
            {
                this.count = bundle.GetInt("count", 0);
                button.Text = string.Format("{0} clicks!", this.count);
            }
        }

		protected override void OnSaveInstanceState(Bundle outState)
		{
			base.OnSaveInstanceState(outState);
			outState.PutInt("count", this.count);
		}
	}
}

