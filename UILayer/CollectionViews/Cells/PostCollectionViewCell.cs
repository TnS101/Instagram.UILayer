using System;
using FFImageLoading;
using Foundation;
using UILayer.UILayer.Common.UI;
using UIKit;

namespace UILayer.UILayer.CollectionViews.Cells
{
    public partial class PostCollectionViewCell : UICollectionViewCell
    {
        public static readonly NSString Key = new NSString("PostCollectionViewCell");
        public static readonly UINib Nib;

        static PostCollectionViewCell()
        {
            Nib = UINib.FromName("PostCollectionViewCell", NSBundle.MainBundle);
        }

        protected PostCollectionViewCell(IntPtr handle) : base(handle)
        {
        }

        public void UpdateCell(string imagePath, bool usesURL)
        {
            if (usesURL)
            {
                ImageService.Instance.LoadUrl(imagePath).DownSample(98, 98).Into(PostImageView);
            }
            else
            {
                ImageService.Instance.LoadFile(imagePath).DownSample(98, 98).Into(PostImageView);
            }

            Styler.SetBorders(PostImageView, UIColor.Black, 0.8f);
        }

    }
}
