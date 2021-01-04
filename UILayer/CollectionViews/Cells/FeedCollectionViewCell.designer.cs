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
	[Register ("FeedCollectionViewCell")]
	partial class FeedCollectionViewCell
	{
		[Outlet]
		UIKit.UIButton DeleteButton { get; set; }

		[Outlet]
		UIKit.UILabel DescriptionLabel { get; set; }

		[Outlet]
		UIKit.UIButton LikeButton { get; set; }

		[Outlet]
		UIKit.UILabel LikesCountLabel { get; set; }

		[Outlet]
		UIKit.UIImageView PostImageView { get; set; }

		[Outlet]
		UIKit.UIImageView UserImageView { get; set; }

		[Outlet]
		UIKit.UILabel UserTagLabel { get; set; }
		
		void ReleaseDesignerOutlets ()
		{
			if (DescriptionLabel != null) {
				DescriptionLabel.Dispose ();
				DescriptionLabel = null;
			}

			if (LikeButton != null) {
				LikeButton.Dispose ();
				LikeButton = null;
			}

			if (LikesCountLabel != null) {
				LikesCountLabel.Dispose ();
				LikesCountLabel = null;
			}

			if (PostImageView != null) {
				PostImageView.Dispose ();
				PostImageView = null;
			}

			if (UserImageView != null) {
				UserImageView.Dispose ();
				UserImageView = null;
			}

			if (UserTagLabel != null) {
				UserTagLabel.Dispose ();
				UserTagLabel = null;
			}

			if (DeleteButton != null) {
				DeleteButton.Dispose ();
				DeleteButton = null;
			}
		}
	}
}
