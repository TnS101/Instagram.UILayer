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
	[Register ("FollowersViewController")]
	partial class FollowersViewController
	{
		[Outlet]
		UIKit.UIButton AddPostButton { get; set; }

		[Outlet]
		UIKit.UIButton AllUsersButton { get; set; }

		[Outlet]
		UIKit.UIButton FollowersButton { get; set; }

		[Outlet]
		UIKit.UIButton FollowingButton { get; set; }

		[Outlet]
		UIKit.UIButton FriendsButton { get; set; }

		[Outlet]
		UIKit.UIButton HomeButton { get; set; }

		[Outlet]
		UIKit.UIButton ProfileButton { get; set; }

		[Outlet]
		UIKit.UICollectionView UsersCollectionView { get; set; }
		
		void ReleaseDesignerOutlets ()
		{
			if (AllUsersButton != null) {
				AllUsersButton.Dispose ();
				AllUsersButton = null;
			}

			if (FollowersButton != null) {
				FollowersButton.Dispose ();
				FollowersButton = null;
			}

			if (FollowingButton != null) {
				FollowingButton.Dispose ();
				FollowingButton = null;
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

			if (UsersCollectionView != null) {
				UsersCollectionView.Dispose ();
				UsersCollectionView = null;
			}
		}
	}
}
