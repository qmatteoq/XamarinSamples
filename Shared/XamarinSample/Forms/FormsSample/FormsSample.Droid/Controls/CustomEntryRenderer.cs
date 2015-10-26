using Android.Provider;
using FormsSample.Controls;
using FormsSample.Droid.Controls;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;

[assembly: ExportRenderer(typeof(CustomEntry), typeof(CustomEntryRenderer))]
namespace FormsSample.Droid.Controls
{
    public class CustomEntryRenderer: EntryRenderer
    {
        protected override void OnElementChanged(ElementChangedEventArgs<Entry> e)
        {
            base.OnElementChanged(e);
            Control.SetBackgroundColor(global::Android.Graphics.Color.Orange);
        }
    }
}
