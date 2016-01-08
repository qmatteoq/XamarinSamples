using System;
using GalaSoft.MvvmLight.Helpers;
using Microsoft.Practices.ServiceLocation;
using UIKit;
using XamarinMVVM.Shared.ViewModels;

namespace XamarinMVVM.iOS
{
    public partial class ViewController : UIViewController
    {
        public MainViewModel ViewModel => ServiceLocator.Current.GetInstance<MainViewModel>();

        private Binding _coordinatesBinding;

        public ViewController(IntPtr handle) : base(handle)
        {
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            // Perform any additional setup after loading the view, typically from a nib.

            _coordinatesBinding = this.SetBinding(() => ViewModel.Coordinates, () => CoordinatesLabel.Text);
            GetPositionButton.SetCommand("TouchUpInside", ViewModel.GetPositionCommand);
        }

        public override void DidReceiveMemoryWarning()
        {
            base.DidReceiveMemoryWarning();
            // Release any cached data, images, etc that aren't in use.
        }
    }
}