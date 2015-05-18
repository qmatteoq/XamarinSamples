using Foundation;
using System;
using System.CodeDom.Compiler;
using UIKit;

namespace AdvancedStoryboard
{
	partial class DetailViewController : UIViewController
	{
	    public string Username { get; set; }

		public DetailViewController (IntPtr handle) : base (handle)
		{
		}

	    public override void ViewWillAppear(bool animated)
	    {
	        UsernameLabel.Text = Username;
	        base.ViewWillAppear(animated);
	    }
	}
}
