using System;
using FFImageLoading;
using Foundation;
using UIKit;

namespace UILayer.UILayer.CollectionViews.Cells
{
    public partial class GalleryCollectionViewCell : UICollectionViewCell
    {
        public static readonly NSString Key = new NSString("GalleryCollectionViewCell");
        public static readonly UINib Nib;

        public Action SelectImageAction;

        static GalleryCollectionViewCell()
        {
            Nib = UINib.FromName("GalleryCollectionViewCell", NSBundle.MainBundle);
        }

        protected GalleryCollectionViewCell(IntPtr handle) : base(handle)
        {
        }

        public void UpdateCell(string imagePath)
        {
            ImageService.Instance.LoadFile(imagePath).DownSample(90, 90).Into(GalleryImageView);
        }


        public void ToggleImage(string imagePath, UIImageView imageView)
        {
            SelectImageAction?.Invoke();

            ImageService.Instance.LoadFile(imagePath).DownSample(388, 388).Into(imageView);
        }
    }
}
