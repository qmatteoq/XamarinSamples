using Android.Content;
using Step2.Droid.Services;
using Step2.Services;
using Xamarin.Forms;

[assembly: Dependency(typeof(DroidShareService))]
namespace Step2.Droid.Services
{
    public class DroidShareService : IShareService
    {
        public void Share(string title, string url)
        {
            var intent = new Intent(Intent.ActionSend);
            intent.SetType("text/plain");
            intent.PutExtra(Intent.ExtraText, url);

            if (title != null)
            {
                intent.PutExtra(Intent.ExtraSubject, title);
            }

            var chooserIntent = Intent.CreateChooser(intent, title);
            chooserIntent.SetFlags(ActivityFlags.ClearTop);
            chooserIntent.SetFlags(ActivityFlags.NewTask);
            Forms.Context.StartActivity(chooserIntent);
        }
    }
}