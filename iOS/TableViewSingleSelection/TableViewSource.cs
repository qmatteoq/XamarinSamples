using System;
using Foundation;
using UIKit;

namespace TableViewSingleSelection
{
    public class TableViewSource: UITableViewSource
    {
        string[] tableItems;
        static readonly NSString CellIdentifier = new NSString("Cell");
        private RootViewController _parent;

        public TableViewSource(string[] items, RootViewController parent)
        {
            _parent = parent;
            this.tableItems = items;
        }

        public override UITableViewCell GetCell(UITableView tableView, NSIndexPath indexPath)
        {
            UITableViewCell cell = tableView.DequeueReusableCell(CellIdentifier, indexPath);
            cell.TextLabel.Text = tableItems[indexPath.Row];
            cell.UserInteractionEnabled = true;

            return cell;
        }

        public override nint RowsInSection(UITableView tableview, nint section)
        {
            return tableItems.Length;
        }

        public override void RowSelected(UITableView tableView, NSIndexPath indexPath)
        {
            UIAlertController alertController = UIAlertController.Create("Item selected", tableItems[indexPath.Row], UIAlertControllerStyle.Alert);
            UIAlertAction action = UIAlertAction.Create("Ok", UIAlertActionStyle.Default, null);
            alertController.AddAction(action);

            this._parent.PresentViewController(alertController, true, null);
        }
    }
}