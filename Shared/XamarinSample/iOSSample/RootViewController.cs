using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using Foundation;
using NewsLibrary.Models;
using NewsLibrary.Services;
using UIKit;

namespace iOSSample
{
    public partial class RootViewController : UITableViewController
    {
        private string[] items;
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

        public override async void ViewDidLoad()
        {
            base.ViewDidLoad();

            // Perform any additional setup after loading the view, typically from a nib.
            RssService service = new RssService();
            List<FeedItem> list = await service.GetNews("http://feeds.feedburner.com/qmatteoq_eng");

            items = list.Select(x => x.Title).ToArray();
            TableView.Source = new TableViewSource(items);
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
    }
}