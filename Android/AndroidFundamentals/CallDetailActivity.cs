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

namespace AndroidFundamentals
{
    [Activity(Label = "CallDetailActivity")]
    public class CallDetailActivity : Activity
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            // Create your application here
            SetContentView(Resource.Layout.Detail);

            IList<string> parameters = Intent.Extras.GetStringArrayList("phone_numbers") ?? new string[0];
            string phoneNumber = parameters[0];

            TextView phoneNumberView = this.FindViewById<TextView>(Resource.Id.PhoneNumber);
            Button callButton = this.FindViewById<Button>(Resource.Id.Call);

            phoneNumberView.Text = phoneNumber;

            callButton.Click += (sender, args) =>
            {
                var dialog = new AlertDialog.Builder(this);

                dialog.SetTitle("Title");
                dialog.SetMessage("Message Goes Here");

                dialog.SetNegativeButton("No", (o, e) => { });
                dialog.SetNeutralButton("Maybe", (o, e) => { });
                dialog.SetPositiveButton("Yes", (o, e) => { });

                dialog.Show();
                //var callIntent = new Intent(Intent.ActionCall);
                //callIntent.SetData(Android.Net.Uri.Parse("tel:" + phoneNumber));
                //StartActivity(callIntent);
            };


        }
    }
}