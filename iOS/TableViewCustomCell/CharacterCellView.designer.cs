// WARNING
//
// This file has been generated automatically by Xamarin Studio from the outlets and
// actions declared in your storyboard file.
// Manual changes to this file will not be maintained.
//
using Foundation;
using System;
using System.CodeDom.Compiler;
using UIKit;

namespace TableViewCustomCell
{
	[Register ("CharacterCellView")]
	partial class CharacterCellView
	{
		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UILabel NameText { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UILabel YearText { get; set; }

		void ReleaseDesignerOutlets ()
		{
			if (NameText != null) {
				NameText.Dispose ();
				NameText = null;
			}
			if (YearText != null) {
				YearText.Dispose ();
				YearText = null;
			}
		}
	}
}
