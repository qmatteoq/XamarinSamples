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

namespace XamarinMVVM.iOS
{
	[Register ("ViewController")]
	partial class ViewController
	{
		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UILabel CoordinatesLabel { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UIButton GetPositionButton { get; set; }

		void ReleaseDesignerOutlets ()
		{
			if (CoordinatesLabel != null) {
				CoordinatesLabel.Dispose ();
				CoordinatesLabel = null;
			}
			if (GetPositionButton != null) {
				GetPositionButton.Dispose ();
				GetPositionButton = null;
			}
		}
	}
}
