using System;
using System.Drawing;
using System.Collections.Generic;
using Foundation;
using UIKit;

namespace TableViewSample
{
    public partial class MasterViewController : UITableViewController
    {
        private string[] items;

        public MasterViewController(IntPtr handle)
            : base(handle)
        {
        }

        public override void DidReceiveMemoryWarning()
        {
            // Releases the view if it doesn't have a superview.
            base.DidReceiveMemoryWarning();

            // Release any cached data, images, etc that aren't in use.
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();

            items = new string[] { "Captain America", "Spiderman", "Iron Man", "Thor", "Hulk" };
            TableView.Source = new TableViewSource(items);
        }

        public override void PrepareForSegue(UIStoryboardSegue segue, NSObject sender)
        {
            if (segue.Identifier == "showDetail")
            {
                var indexPath = TableView.IndexPathForSelectedRow;
                var item = items[indexPath.Row];

                ((DetailViewController)segue.DestinationViewController).SetDetailItem(item);
            }
        }
    }
}
