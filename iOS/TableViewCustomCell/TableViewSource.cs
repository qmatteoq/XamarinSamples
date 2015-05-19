using System;
using Foundation;
using TableViewCustomCell.Entities;
using UIKit;

namespace TableViewCustomCell
{
    public class TableViewSource: UITableViewSource
    {
        Character[] tableItems;
        static readonly NSString CellIdentifier = new NSString("Cell");
        public TableViewSource(Character[] items)
        {
            this.tableItems = items;
        }

        public override UITableViewCell GetCell(UITableView tableView, NSIndexPath indexPath)
        {
            CharacterCellView cell = tableView.DequeueReusableCell(CellIdentifier, indexPath) as CharacterCellView;
            Character currentCharacter = tableItems[indexPath.Row];
            cell.UpdateCharacter(currentCharacter);
            cell.UserInteractionEnabled = true;

            return cell;
        }

        public override nint RowsInSection(UITableView tableview, nint section)
        {
            return tableItems.Length;
        }

    }
}