using System;
using System.Collections.Generic;
using System.Linq;

using MonoTouch.Foundation;
using MonoTouch.UIKit;
using MonoTouch.FacebookConnect;

namespace FacebookLogin
{
	// The UIApplicationDelegate for the application. This class is responsible for launching the
	// User Interface of the application, as well as listening (and optionally responding) to
	// application events from iOS.
	[Register("AppDelegate")]
	public partial class AppDelegate : UIApplicationDelegate
	{
		// class-level declarations
		UIWindow window;
		FacebookLoginViewController viewController;

		//
		// This method is invoked when the application has loaded and is ready to run. In this
		// method you should instantiate the window, load the UI into it and then make the window
		// visible.
		//
		// You have 17 seconds to return from this method, or iOS will terminate your application.
		//
		public override bool FinishedLaunching(UIApplication app, NSDictionary options)
		{
			FBSettings.DefaultAppID = "1234567890";
			FBSettings.DefaultDisplayName = "FacebookLogin";

			window = new UIWindow(UIScreen.MainScreen.Bounds);
			
			viewController = new FacebookLoginViewController();
			window.RootViewController = viewController;
			window.MakeKeyAndVisible();
			
			return true;
		}

		public override bool OpenUrl(UIApplication application, NSUrl url, string sourceApplication, NSObject annotation)
		{
			return FBSession.ActiveSession.HandleOpenURL(url);
		}

		public override void OnActivated(UIApplication application)
		{
			FBSession.ActiveSession.HandleDidBecomeActive();
		}
	}
}

