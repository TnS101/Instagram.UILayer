using System;
using System.Collections.Generic;
using Foundation;
using Domain.Database.Tables;
using UILayer.UILayer.CollectionViews.Cells;
using UIKit;
using Application.ApplicationLayer.Services.Users;
using Domain.Database;
using System.Diagnostics;

namespace UILayer.UILayer.CollectionViews
{
    public class FeedCollectionViewSource : UICollectionViewSource, ISource<Post>
    {
        private List<Post> posts;
        private readonly string userId;
        private readonly UserReads userReads;

        public event EventHandler OnItemChanged;

        public FeedCollectionViewSource(string userId)
        {
            this.userId = userId;
            userReads = new UserReads(new DbContext());
        }

        public void LoadData(List<Post> data)
        {
            posts = data;
        }

        public override nint NumberOfSections(UICollectionView collectionView)
        {
            return 1;
        }

        public override nint GetItemsCount(UICollectionView collectionView, nint section)
        {
            return posts.Count;
        }

        public override UICollectionViewCell GetCell(UICollectionView collectionView, NSIndexPath indexPath)
        {
            var post = posts[indexPath.Row];
            var postAuthor = userReads.Get(post.UserId);

            var cell = (FeedCollectionViewCell)collectionView.DequeueReusableCell(FeedCollectionViewCell.Key, indexPath);

            cell.UpdateCell(post.Id, userId, postAuthor.Id, postAuthor.ImagePath, postAuthor.UserTag, post.ImagePath, post.Description, post.Likes, post.UsesURL);

            cell.DataContext.DeleteItemAction = () =>
            {
                OnItemChanged?.Invoke(this, EventArgs.Empty);
            };

            cell.DataContext.LikeAction = () =>
            {
                OnItemChanged?.Invoke(this, EventArgs.Empty);
            };

            return cell;
        }
    }
}
