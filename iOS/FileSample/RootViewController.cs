using System;
using System.Drawing;
using System.IO;
using Foundation;
using UIKit;

namespace FileSample
{
    public partial class RootViewController : UIViewController
    {
        private string Documents;
        private string fileName = "MyFile.txt";

        public RootViewController(IntPtr handle) : base(handle)
        {
        }

        public override void DidReceiveMemoryWarning()
        {
            // Releases the view if it doesn't have a superview.
            base.DidReceiveMemoryWarning();

            // Release any cached data, images, etc that aren't in use.
        }

        #region View lifecycle

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            NSUrl docUri = NSFileManager.DefaultManager.GetUrls(NSSearchPathDirectory.DocumentDirectory, NSSearchPathDomain.User)[0];
            Documents = docUri.Path;

            // Perform any additional setup after loading the view, typically from a nib.
        }

        public override void ViewWillAppear(bool animated)
        {
            base.ViewWillAppear(animated);
        }

        public override void ViewDidAppear(bool animated)
        {
            base.ViewDidAppear(animated);
        }

        public override void ViewWillDisappear(bool animated)
        {
            base.ViewWillDisappear(animated);
        }

        public override void ViewDidDisappear(bool animated)
        {
            base.ViewDidDisappear(animated);
        }

        #endregion

        partial void UIButton6_TouchUpInside(UIButton sender)
        {
            var filename = Path.Combine(Documents, fileName);
            File.WriteAllText(fileName, TextToSave.Text);
        }

        partial void UIButton7_TouchUpInside(UIButton sender)
        {
            var filename = Path.Combine(Documents, fileName);
            string text = File.ReadAllText(fileName);
            TextToDisplay.Text = text;
        }
    }
}