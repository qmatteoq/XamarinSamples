using Android.App;
using MvvmCross.Droid.Views;

namespace RssService.Android
{
    [Activity(Label = "RssService.Android", MainLauncher = true, Icon = "@drawable/icon")]
    public class MainActivity : MvxActivity
    {
        protected override void OnViewModelSet()
        {
            SetContentView(Resource.Layout.Main);
        }
    }
}

