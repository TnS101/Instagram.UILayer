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
	[Register ("PostViewController")]
	partial class PostViewController
	{
		[Outlet]
		UIKit.UIButton AddPictureButton { get; set; }

		[Outlet]
		UIKit.UIButton AddPostButton { get; set; }

		[Outlet]
		UIKit.UIButton CreatePostButton { get; set; }

		[Outlet]
		UIKit.UITextField DescriptionTextField { get; set; }

		[Outlet]
		UIKit.UIButton FriendsButton { get; set; }

		[Outlet]
		UIKit.UICollectionView GalleryCollectionView { get; set; }

		[Outlet]
		UIKit.UIButton HomeButton { get; set; }

		[Outlet]
		UIKit.UIImageView PostImageView { get; set; }

		[Outlet]
		UIKit.UIButton ProfileButton { get; set; }
		
		void ReleaseDesignerOutlets ()
		{
			if (AddPictureButton != null) {
				AddPictureButton.Dispose ();
				AddPictureButton = null;
			}

			if (AddPostButton != null) {
				AddPostButton.Dispose ();
				AddPostButton = null;
			}

			if (CreatePostButton != null) {
				CreatePostButton.Dispose ();
				CreatePostButton = null;
			}

			if (DescriptionTextField != null) {
				DescriptionTextField.Dispose ();
				DescriptionTextField = null;
			}

			if (FriendsButton != null) {
				FriendsButton.Dispose ();
				FriendsButton = null;
			}

			if (GalleryCollectionView != null) {
				GalleryCollectionView.Dispose ();
				GalleryCollectionView = null;
			}

			if (HomeButton != null) {
				HomeButton.Dispose ();
				HomeButton = null;
			}

			if (PostImageView != null) {
				PostImageView.Dispose ();
				PostImageView = null;
			}

			if (ProfileButton != null) {
				ProfileButton.Dispose ();
				ProfileButton = null;
			}
		}
	}
}
