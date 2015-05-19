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

namespace FileSample
{
	[Register ("RootViewController")]
	partial class RootViewController
	{
		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UILabel TextToDisplay { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UITextField TextToSave { get; set; }

		[Action ("UIButton6_TouchUpInside:")]
		[GeneratedCode ("iOS Designer", "1.0")]
		partial void UIButton6_TouchUpInside (UIButton sender);

		[Action ("UIButton7_TouchUpInside:")]
		[GeneratedCode ("iOS Designer", "1.0")]
		partial void UIButton7_TouchUpInside (UIButton sender);

		void ReleaseDesignerOutlets ()
		{
			if (TextToDisplay != null) {
				TextToDisplay.Dispose ();
				TextToDisplay = null;
			}
			if (TextToSave != null) {
				TextToSave.Dispose ();
				TextToSave = null;
			}
		}
	}
}
