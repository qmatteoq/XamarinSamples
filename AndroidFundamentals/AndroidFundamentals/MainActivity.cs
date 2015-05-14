using System;
using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;

namespace AndroidFundamentals
{
    [Activity(Label = "AndroidFundamentals", MainLauncher = true, Icon = "@drawable/icon")]
    public class MainActivity : Activity
    {
        int count = 1;

        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);

            // Get our button from the layout resource,
            // and attach an event to it
            Button callButton = this.FindViewById<Button>(Resource.Id.CallButton);
            EditText phoneNumberText = this.FindViewById<EditText>(Resource.Id.PhoneNumberText);

            callButton.Click += (sender, args) =>
            {
                var intent = new Intent(this, typeof(CallDetailActivity));
                intent.PutStringArrayListExtra("phone_numbers", new[] { phoneNumberText.Text});
                this.StartActivity(intent);
            };
        }
    }
}

