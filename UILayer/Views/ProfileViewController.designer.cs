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
	[Register ("ProfileViewController")]
	partial class ProfileViewController
	{
		[Outlet]
		UIKit.UIButton AddPostButton { get; set; }

		[Outlet]
		UIKit.UIButton EditUserButton { get; set; }

		[Outlet]
		UIKit.UIButton FriendsButton { get; set; }

		[Outlet]
		UIKit.UIButton HomeButton { get; set; }

		[Outlet]
		UIKit.UIButton LogoutButton { get; set; }

		[Outlet]
		UIKit.UIButton ProfileButton { get; set; }

		[Outlet]
		UIKit.UILabel UserBioLabel { get; set; }

		[Outlet]
		UIKit.UILabel UserFollowersLabel { get; set; }

		[Outlet]
		UIKit.UILabel UserFollowingLabel { get; set; }

		[Outlet]
		UIKit.UIImageView UserImageView { get; set; }

		[Outlet]
		UIKit.UILabel UsernameLabel { get; set; }

		[Outlet]
		UIKit.UICollectionView UserPostsCollectionView { get; set; }

		[Outlet]
		UIKit.UILabel UserPostsLabel { get; set; }

		[Outlet]
		UIKit.UILabel UserTagLabel { get; set; }
		
		void ReleaseDesignerOutlets ()
		{
			if (AddPostButton != null) {
				AddPostButton.Dispose ();
				AddPostButton = null;
			}

			if (EditUserButton != null) {
				EditUserButton.Dispose ();
				EditUserButton = null;
			}

			if (FriendsButton != null) {
				FriendsButton.Dispose ();
				FriendsButton = null;
			}

			if (HomeButton != null) {
				HomeButton.Dispose ();
				HomeButton = null;
			}

			if (ProfileButton != null) {
				ProfileButton.Dispose ();
				ProfileButton = null;
			}

			if (UserBioLabel != null) {
				UserBioLabel.Dispose ();
				UserBioLabel = null;
			}

			if (UserFollowersLabel != null) {
				UserFollowersLabel.Dispose ();
				UserFollowersLabel = null;
			}

			if (UserFollowingLabel != null) {
				UserFollowingLabel.Dispose ();
				UserFollowingLabel = null;
			}

			if (UserImageView != null) {
				UserImageView.Dispose ();
				UserImageView = null;
			}

			if (UsernameLabel != null) {
				UsernameLabel.Dispose ();
				UsernameLabel = null;
			}

			if (UserPostsCollectionView != null) {
				UserPostsCollectionView.Dispose ();
				UserPostsCollectionView = null;
			}

			if (UserPostsLabel != null) {
				UserPostsLabel.Dispose ();
				UserPostsLabel = null;
			}

			if (UserTagLabel != null) {
				UserTagLabel.Dispose ();
				UserTagLabel = null;
			}

			if (LogoutButton != null) {
				LogoutButton.Dispose ();
				LogoutButton = null;
			}
		}
	}
}
