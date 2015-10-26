using System.Windows.Media;
using FormsSample.Controls;
using FormsSample.WinPhone.Controls;
using Xamarin.Forms;
using Xamarin.Forms.Platform.WinPhone;

[assembly: ExportRenderer(typeof(CustomEntry), typeof(CustomEntryRenderer))]
namespace FormsSample.WinPhone.Controls
{
    public class CustomEntryRenderer: EntryRenderer
    {
        protected override void OnElementChanged(ElementChangedEventArgs<Entry> e)
        {
            base.OnElementChanged(e);
            Control.Background = new SolidColorBrush(Colors.Orange);
        }
    }
}
