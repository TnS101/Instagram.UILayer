using System;
using System.Collections.Generic;
using Foundation;
using UILayer.UILayer.CollectionViews.Cells;
using UIKit;

namespace UILayer.UILayer.CollectionViews
{
    public class GalleryCollectionViewSource : UICollectionViewSource, ISource<string>
    {
        private List<string> paths;
        private readonly UIImageView imagePreview;

        public EventHandler OnImageSelect;

        public static string SelectedImagePath { get; set; }

        public GalleryCollectionViewSource(UIImageView imagePreview)
        {
            this.imagePreview = imagePreview;
        }

        public void LoadData(List<string> data)
        {
            paths = data;
        }

        public override nint NumberOfSections(UICollectionView collectionView)
        {
            return 1;
        }

        public override nint GetItemsCount(UICollectionView collectionView, nint section)
        {
            return paths.Count;
        }

        public override bool ShouldSelectItem(UICollectionView collectionView, NSIndexPath indexPath)
        {
            return true;
        }

        public override void ItemSelected(UICollectionView collectionView, NSIndexPath indexPath)
        {
            var path = paths[indexPath.Row];

            SelectedImagePath = path;

            var cell = (GalleryCollectionViewCell)collectionView.CellForItem(indexPath);

            cell.SelectImageAction = () =>
            {
                OnImageSelect?.Invoke(this, EventArgs.Empty);
            };

            cell.ToggleImage(path, imagePreview);
        }

        public override UICollectionViewCell GetCell(UICollectionView collectionView, NSIndexPath indexPath)
        {
            var path = paths[indexPath.Row];

            var cell = (GalleryCollectionViewCell)collectionView.DequeueReusableCell(GalleryCollectionViewCell.Key, indexPath);

            cell.UpdateCell(path);

            return cell;
        }
    }
}
