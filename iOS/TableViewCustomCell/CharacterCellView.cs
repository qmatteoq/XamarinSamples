using Foundation;
using System;
using System.CodeDom.Compiler;
using TableViewCustomCell.Entities;
using UIKit;

namespace TableViewCustomCell
{
	partial class CharacterCellView : UITableViewCell
	{
		public CharacterCellView (IntPtr handle) : base (handle)
		{
		}

	    public void UpdateCharacter(Character character)
	    {
	        this.NameText.Text = character.Name;
	        this.YearText.Text = character.Year.ToString();
	    }
	}
}
