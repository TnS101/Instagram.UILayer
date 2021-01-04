using System;
using System.Collections.Generic;
using Foundation;
using Domain.Database.Tables;
using UILayer.UILayer.CollectionViews.Cells;
using UIKit;

namespace UILayer.UILayer.CollectionViews
{
    public class PostCollectionViewSource : UICollectionViewSource, ISource<Post>
    {
        private List<List<Post>> rows;

        public PostCollectionViewSource()
        {
        }

        public void LoadData(List<Post> data)
        {
            rows = new List<List<Post>>();

            var currentRow = new List<Post>();

            for (int i = 0; i < data.Count; i++)
            {
                var post = data[i];

                currentRow.Add(post);

                if (currentRow.Count % 3 == 0 || i == data.Count - 1)
                {
                    rows.Add(currentRow);
                    currentRow = new List<Post>();
                }
            }
        }

        public override nint NumberOfSections(UICollectionView collectionView)
        {
            return rows.Count;
        }

        public override nint GetItemsCount(UICollectionView collectionView, nint section)
        {
            return rows[(int)section].Count;
        }

        public override bool ShouldSelectItem(UICollectionView collectionView, NSIndexPath indexPath)
        {
            return true;
        }

        public override void ItemSelected(UICollectionView collectionView, NSIndexPath indexPath)
        {
            var cell = (PostCollectionViewCell)collectionView.CellForItem(indexPath);
            cell.Alpha = 0.5f;
        }

        public override void ItemDeselected(UICollectionView collectionView, NSIndexPath indexPath)
        {
            var cell = (PostCollectionViewCell)collectionView.CellForItem(indexPath);
            cell.Alpha = 1f;
        }

        public override UICollectionReusableView GetViewForSupplementaryElement(UICollectionView collectionView, NSString elementKind, NSIndexPath indexPath)
        {
            var header = (HeaderCollectionViewCell)collectionView.DequeueReusableSupplementaryView(UICollectionElementKindSection.Header, HeaderCollectionViewCell.Key, indexPath);

            header.UpdateCell();

            return header;
        }

        public override UICollectionViewCell GetCell(UICollectionView collectionView, NSIndexPath indexPath)
        {
            var post = rows[indexPath.Section][indexPath.Row];

            var cell = (PostCollectionViewCell)collectionView.DequeueReusableCell(PostCollectionViewCell.Key, indexPath);

            cell.UpdateCell(post.ImagePath, post.UsesURL);

            return cell;
        }
    }
}
