using System;
using System.Collections.Generic;
using Foundation;
using Application.ApplicationLayer.DTOs.Users;
using UILayer.UILayer.CollectionViews.Cells;
using UIKit;

namespace UILayer.UILayer.CollectionViews
{
    public class FollowersCollectionViewSource : UICollectionViewSource, ISource<UserMinDTO>
    {
        private List<UserMinDTO> users;
        private readonly string userId;

        public event EventHandler OnItemChanged;

        public FollowersCollectionViewSource(string userId)
        {
            this.userId = userId;
        }

        public void LoadData(List<UserMinDTO> data)
        {
            this.users = data;
        }

        public override nint NumberOfSections(UICollectionView collectionView)
        {
            return 1;
        }

        public override nint GetItemsCount(UICollectionView collectionView, nint section)
        {
            return users.Count;
        }

        public override UICollectionViewCell GetCell(UICollectionView collectionView, NSIndexPath indexPath)
        {
            var follower = users[indexPath.Row];

            var cell = (FollowerCollectionViewCell)collectionView.DequeueReusableCell(FollowerCollectionViewCell.Key, indexPath);

            cell.UpdateCell(userId, follower.Id, follower.ImagePath, follower.Username, follower.UserTag);

            cell.DataContext.OnFollowAction = () =>
            {
                OnItemChanged?.Invoke(this, EventArgs.Empty);
            };

            return cell;
        }
    }
}
