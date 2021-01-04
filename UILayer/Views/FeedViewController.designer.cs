// WARNING
//
// This file has been generated automatically by Visual Studio to store outlets and
// actions made in the UI designer. If it is removed, they will be lost.
// Manual changes to this file may not be handled correctly.
//
using Foundation;
using System.CodeDom.Compiler;

namespace UILayer.UILayer.Views
{
	[Register ("FeedViewController")]
	partial class FeedViewController
	{
		[Outlet]
		UIKit.UIButton AddPostButton { get; set; }

		[Outlet]
		UIKit.UICollectionView FeedCollectionView { get; set; }

		[Outlet]
		UIKit.UIButton FriendsButton { get; set; }

		[Outlet]
		UIKit.UIButton HomeButton { get; set; }

		[Outlet]
		UIKit.UIButton ProfileButton { get; set; }
		
		void ReleaseDesignerOutlets ()
		{
			if (FeedCollectionView != null) {
				FeedCollectionView.Dispose ();
				FeedCollectionView = null;
			}

			if (HomeButton != null) {
				HomeButton.Dispose ();
				HomeButton = null;
			}

			if (FriendsButton != null) {
				FriendsButton.Dispose ();
				FriendsButton = null;
			}

			if (AddPostButton != null) {
				AddPostButton.Dispose ();
				AddPostButton = null;
			}

			if (ProfileButton != null) {
				ProfileButton.Dispose ();
				ProfileButton = null;
			}
		}
	}
}
