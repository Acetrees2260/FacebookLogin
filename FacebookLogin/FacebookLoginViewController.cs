using System;
using System.Drawing;

using MonoTouch.Foundation;
using MonoTouch.UIKit;
using MonoTouch.FacebookConnect;

namespace FacebookLogin
{
	public partial class FacebookLoginViewController : UIViewController
	{
		public FacebookLoginViewController() : base("FacebookLoginViewController", null)
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
			
			// Perform any additional setup after loading the view, typically from a nib.
		}

		partial void loginClick(NSObject sender)
		{
			var newSession = new FBSession();

			FBSession.ActiveSession = newSession;

			newSession.Open((session, status, error) =>
			{
				if (status == FBSessionState.Open)
				{
					var accessToken = session.AccessTokenData.AccessToken;
				}
			});
		}
	}
}

