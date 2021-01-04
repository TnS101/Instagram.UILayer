using System;
using System.Diagnostics;
using Application.ApplicationLayer.ViewModels.Cells;
using FFImageLoading;
using Foundation;
using GalaSoft.MvvmLight.Helpers;
using UILayer.UILayer.Common.UI;
using UIKit;

namespace UILayer.UILayer.CollectionViews.Cells
{
    public partial class FeedCollectionViewCell : UICollectionViewCell
    {
        public static readonly NSString Key = new NSString("FeedCollectionViewCell");
        public static readonly UINib Nib;

        public FeedCellViewModel DataContext;

        static FeedCollectionViewCell()
        {
            Nib = UINib.FromName("FeedCollectionViewCell", NSBundle.MainBundle);
        }

        protected FeedCollectionViewCell(IntPtr handle) : base(handle)
        {
            DataContext = new FeedCellViewModel();
        }

        public override void AwakeFromNib()
        {
            base.AwakeFromNib();

            DeleteButton.SetCommand(DataContext.DeletePostCommand);
            LikeButton.SetCommand(DataContext.LikePostCommand);
        }

        public void UpdateCell(string postId, string userId, string authorId, string authorImagePath, string authorTag, string imagePath, string description, int likes, bool usesURL)
        {
            ImageService.Instance.LoadUrl(authorImagePath).DownSample(45, 45).Into(UserImageView);

            if (usesURL)
            {
                ImageService.Instance.LoadUrl(imagePath).DownSample(388, 388).Into(PostImageView);
            }
            else
            {
                ImageService.Instance.LoadFile(imagePath).DownSample(388, 388).Into(PostImageView);

                Debug.WriteLine(imagePath);
            }

            UserTagLabel.Text = authorTag;
            DescriptionLabel.Text = description;
            LikesCountLabel.Text = likes.ToString();

            DataContext.UserId = userId;
            DataContext.PostId = postId;
            DataContext.AuthorId = authorId;

            if (userId == authorId)
            {
                DeleteButton.Hidden = false;
            }
            else
            {
                DeleteButton.Hidden = true;
            }

            Styler.SetTextColor(LikesCountLabel, Colors.mainFontColor);
            Styler.SetBorderRadius(UserImageView, UserImageView.Frame.Size.Width / 2);

            Styler.SetTextColor(DeleteButton, Colors.mainFontColor);
            Styler.SetTextColor(DeleteButton, UIColor.Red, UIControlState.Selected);
        }
    }
}
