using System;
using Foundation;
using UIKit;

namespace iOSSample
{
    public class TableViewSource: UITableViewSource
    {
        string[] tableItems;

        static readonly NSString CellIdentifier = new NSString("Cell");
        public TableViewSource(string[] items)
        {
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

    }
}