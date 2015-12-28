using Xamarin.Forms;
using Xamarin.Forms.Platform.UWP;
using XamarinForms.Step4.Controls;
using XamarinForms.Step4.UWP.Controls;

[assembly: ExportRenderer(typeof(CustomSearch), typeof(CustomSearchRenderer))]
namespace XamarinForms.Step4.UWP.Controls
{
    public class CustomSearchRenderer: SearchBarRenderer
    {
        protected override void OnElementChanged(ElementChangedEventArgs<SearchBar> e)
        {
            base.OnElementChanged(e);
            if (Control != null)
            {
                Control.TextChanged += Control_TextChanged;
            }
        }

        private void Control_TextChanged(Windows.UI.Xaml.Controls.AutoSuggestBox sender, Windows.UI.Xaml.Controls.AutoSuggestBoxTextChangedEventArgs args)
        {
            if (sender.Text.Length > 10)
            {
                sender.Text = sender.Text.Substring(0, 10);
            }
        }
    }
}
