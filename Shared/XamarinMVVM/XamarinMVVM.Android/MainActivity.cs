using Android.App;
using Android.Widget;
using Android.OS;
using GalaSoft.MvvmLight.Helpers;
using GalaSoft.MvvmLight.Ioc;
using GalaSoft.MvvmLight.Views;
using Microsoft.Practices.ServiceLocation;
using XamarinMVVM.Android.Services;
using XamarinMVVM.Shared.Services;
using XamarinMVVM.Shared.ViewModels;

namespace XamarinMVVM.Android
{
    [Activity(Label = "XamarinMVVM.Android", MainLauncher = true, Icon = "@drawable/icon")]
    public class MainActivity : ActivityBase
    {
        public MainViewModel ViewModel => ServiceLocator.Current.GetInstance<MainViewModel>();

        private Binding _coordinatesBinding;

        protected override void OnCreate(Bundle bundle)
        {
            if (!SimpleIoc.Default.IsRegistered<IDialogService>())
            {
                ServiceLocator.SetLocatorProvider(() => SimpleIoc.Default);
                SimpleIoc.Default.Register<ILocatorService, LocatorService>();
                SimpleIoc.Default.Register<MainViewModel>();
            }

            base.OnCreate(bundle);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);

            // Get our button from the layout resource,
            // and attach an event to it
            Button button = FindViewById<Button>(Resource.Id.GetPositionButton);

            button.SetCommand("Click", ViewModel.GetPositionCommand);
            _coordinatesBinding = this.SetBinding(() => ViewModel.Coordinates, () => CoordinatesText.Text);

        }

        private TextView _coordinatesText;
        public TextView CoordinatesText => _coordinatesText
                                           ?? (_coordinatesText = FindViewById<TextView>(Resource.Id.CoordinatesLabel));
    }
}

