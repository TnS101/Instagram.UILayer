using System;
using Application.ApplicationLayer.ViewModels.Cells;
using FFImageLoading;
using Foundation;
using GalaSoft.MvvmLight.Helpers;
using UILayer.UILayer.Common.UI;
using UIKit;

namespace UILayer.UILayer.CollectionViews.Cells
{
    public partial class FollowerCollectionViewCell : UICollectionViewCell
    {
        public static readonly NSString Key = new NSString("FollowerCollectionViewCell");
        public static readonly UINib Nib;

        public FollowerCellViewModel DataContext;

        static FollowerCollectionViewCell()
        {
            Nib = UINib.FromName("FollowerCollectionViewCell", NSBundle.MainBundle);
        }

        protected FollowerCollectionViewCell(IntPtr handle) : base(handle)
        {
            DataContext = new FollowerCellViewModel();
        }

        public override void AwakeFromNib()
        {
            base.AwakeFromNib();

            FollowButton.SetCommand(DataContext.FollowCommand);
        }

        public void UpdateCell(string userId, string targetUserId, string targetUserImagePath, string targetUserUsername, string targetUserUserTag)
        {
            ImageService.Instance.LoadUrl(targetUserImagePath).DownSample(62, 62).Into(UserImageView);
            UsernameLabel.Text = targetUserUsername;
            UserTagLabel.Text = targetUserUserTag;

            DataContext.UserId = userId;
            DataContext.TargetUserId = targetUserId;

            if (DataContext.UserIsFollowed)
            {
                FollowButton.SetTitle("Unfollow", UIControlState.Normal);
            }
            else
            {
                FollowButton.SetTitle("Follow", UIControlState.Normal);
            }

            Styler.SetBorderRadius(UserImageView, UserImageView.Frame.Size.Width / 2);
            Styler.SetBorderRadius(FollowButton, FollowButton.Frame.Size.Width / 12);
            Styler.SetBorders(FollowButton, Colors.mainFontColor, 0.5f);
            Styler.SetTextColor(FollowButton, Colors.secondFontColor);
        }
    }
}
