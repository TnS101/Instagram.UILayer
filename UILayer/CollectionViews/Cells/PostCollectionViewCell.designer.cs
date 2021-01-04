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
	[Register ("PostCollectionViewCell")]
	partial class PostCollectionViewCell
	{
		[Outlet]
		UIKit.UIImageView PostImageView { get; set; }
		
		void ReleaseDesignerOutlets ()
		{
			if (PostImageView != null) {
				PostImageView.Dispose ();
				PostImageView = null;
			}
		}
	}
}
