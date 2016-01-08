using GalaSoft.MvvmLight.Ioc;
using Microsoft.Practices.ServiceLocation;
using XamarinMVVM.Shared.Services;
using XamarinMVVM.Shared.ViewModels;
using XamarinMVVM.UWP.Services;

namespace XamarinMVVM.UWP.ViewModels
{
    /// <summary>
    /// This class contains static references to all the view models in the
    /// application and provides an entry point for the bindings.
    /// </summary>
    public class ViewModelLocator
    {
        /// <summary>
        /// Initializes a new instance of the ViewModelLocator class.
        /// </summary>
        public ViewModelLocator()
        {
            ServiceLocator.SetLocatorProvider(() => SimpleIoc.Default);

            SimpleIoc.Default.Register<ILocatorService, LocatorService>();

            SimpleIoc.Default.Register<MainViewModel>();
        }

        public MainViewModel Main => ServiceLocator.Current.GetInstance<MainViewModel>();
    }
}