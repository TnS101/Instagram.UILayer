// WARNING
//
// This file has been generated automatically by Visual Studio to store outlets and
// actions made in the UI designer. If it is removed, they will be lost.
// Manual changes to this file may not be handled correctly.
//
using Foundation;
using System.CodeDom.Compiler;

namespace UILayer.UILayer.CollectionViews.Cells
{
	[Register ("FollowerCollectionViewCell")]
	partial class FollowerCollectionViewCell
	{
		[Outlet]
		UIKit.UIButton FollowButton { get; set; }

		[Outlet]
		UIKit.UIImageView UserImageView { get; set; }

		[Outlet]
		UIKit.UILabel UsernameLabel { get; set; }

		[Outlet]
		UIKit.UILabel UserTagLabel { get; set; }
		
		void ReleaseDesignerOutlets ()
		{
			if (UserImageView != null) {
				UserImageView.Dispose ();
				UserImageView = null;
			}

			if (UserTagLabel != null) {
				UserTagLabel.Dispose ();
				UserTagLabel = null;
			}

			if (UsernameLabel != null) {
				UsernameLabel.Dispose ();
				UsernameLabel = null;
			}

			if (FollowButton != null) {
				FollowButton.Dispose ();
				FollowButton = null;
			}
		}
	}
}
