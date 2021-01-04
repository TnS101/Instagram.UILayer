using System;
using System.Collections.Generic;
using System.Linq;
using Application.ApplicationLayer.ViewModels;
using FFImageLoading;
using GalaSoft.MvvmLight.Helpers;
using UILayer.UILayer.CollectionViews;
using UILayer.UILayer.CollectionViews.Cells;
using UILayer.UILayer.Common;
using UILayer.UILayer.Common.Navigation;
using UILayer.UILayer.Common.UI;
using UIKit;

namespace UILayer.UILayer.Views
{
    public partial class ProfileViewController : UIViewController, IBinder, IStyler
    {
        private readonly ProfileViewModel dataContext;
        private readonly PostCollectionViewSource source;
        public List<Binding> Bindings { get; set; }

        public ProfileViewController(IntPtr handle) : base(handle)
        {
            dataContext = new ProfileViewModel(CurrentUser.UserId);
            Bindings = new List<Binding>();

            source = new PostCollectionViewSource();
            source.LoadData(dataContext.Posts.ToList());
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();

            SetBindings();
            SetCommands();
            BaseStyling();
            EventStyling();

            NavigationBar.Set(this, HomeButton, FriendsButton, AddPostButton, ProfileButton);

            UserPostsCollectionView.RegisterNibForCell(PostCollectionViewCell.Nib, PostCollectionViewCell.Key);
            UserPostsCollectionView.RegisterNibForSupplementaryView(HeaderCollectionViewCell.Nib, UICollectionElementKindSection.Header, HeaderCollectionViewCell.Key);

            var layout = new UICollectionViewFlowLayout
            {
                ItemSize = new CoreGraphics.CGSize(100, 100),
                HeaderReferenceSize = new CoreGraphics.CGSize(122, 20)
            };

            UserPostsCollectionView.SetCollectionViewLayout(layout, true);

            UserPostsCollectionView.Source = source;
            UserPostsCollectionView.ReloadData();

            LogoutButton.TouchUpInside += (o, e) =>
            {
                CurrentUser.UserId = string.Empty;
                Navigator.Navigate(this, CtrConst.LoginController);
            };

            UserImageView.ClipsToBounds = true;
            UserImageView.ContentMode = UIViewContentMode.ScaleAspectFill;

            ImageService.Instance.LoadUrl(dataContext.ImagePath)
                .DownSample(80, 80).Into(UserImageView);
        }

        public void SetBindings()
        {
            Bindings.Add(this.SetBinding(
                () => dataContext.Username,
                () => UsernameLabel.Text
            ));

            Bindings.Add(this.SetBinding(
                () => dataContext.UserTag,
                () => UserTagLabel.Text
            ));

            Bindings.Add(this.SetBinding(
                () => dataContext.Bio,
                () => UserBioLabel.Text
            ));

            Bindings.Add(this.SetBinding(
                () => dataContext.PostsCount,
                () => UserPostsLabel.Text
            ).ConvertSourceToTarget((s) =>
            {
                return UserPostsLabel.Text = s.ToString();
            }));

            Bindings.Add(this.SetBinding(
                () => dataContext.FollowersCount,
                () => UserFollowersLabel.Text
            ).ConvertSourceToTarget((s) =>
            {
                return UserFollowersLabel.Text = s.ToString();
            }));

            Bindings.Add(this.SetBinding(
                () => dataContext.FollowingCount,
                () => UserFollowingLabel.Text
            ).ConvertSourceToTarget((s) =>
            {
                return UserFollowingLabel.Text = s.ToString();
            }));
        }

        public void SetCommands()
        {
            EditUserButton.SetCommand(dataContext.EditProfileCommand);
        }

        public void BaseStyling()
        {
            Styler.SetBorderRadius(UserImageView, UserImageView.Frame.Width / 2);
            Styler.SetBorders(EditUserButton, Colors.secondFontColor, 1f);
            Styler.SetBorderRadius(EditUserButton, EditUserButton.Frame.Width / 15);
        }

        public void EventStyling()
        {
        }
    }
}
