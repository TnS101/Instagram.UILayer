using System;
using System.Collections.Generic;
using Application.ApplicationLayer.ViewModels;
using GalaSoft.MvvmLight.Helpers;
using UILayer.UILayer.CollectionViews;
using UILayer.UILayer.CollectionViews.Cells;
using UILayer.UILayer.Common;
using UILayer.UILayer.Common.Navigation;
using UILayer.UILayer.Common.UI;
using UIKit;

namespace UILayer.UILayer.Views
{
	public partial class PostViewController : UIViewController, IBinder, IStyler
	{
		private readonly PostViewModel dataContext;
        private GalleryCollectionViewSource source;

        public List<Binding> Bindings { get; set; }

        public PostViewController (IntPtr handle) : base (handle)
		{
            dataContext = new PostViewModel(CurrentUser.UserId);
            Bindings = new List<Binding>();
		}

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();

            source = new GalleryCollectionViewSource(PostImageView);
            source.LoadData(dataContext.GaleryImagePaths);

            SetBindings();
            SetCommands();
            BaseStyling();
            EventStyling();

            NavigationBar.Set(this, HomeButton, FriendsButton, AddPostButton, ProfileButton);

            GalleryCollectionView.RegisterNibForCell(GalleryCollectionViewCell.Nib, GalleryCollectionViewCell.Key);

            var layout = new UICollectionViewFlowLayout
            {
                ItemSize = new CoreGraphics.CGSize(90, 90)
            };

            GalleryCollectionView.SetCollectionViewLayout(layout, true);

            GalleryCollectionView.Source = source;
            GalleryCollectionView.ReloadData();

            source.OnImageSelect += (o, e) =>
            {
                if (GalleryCollectionViewSource.SelectedImagePath != null)
                {
                    dataContext.SelectedImagePath = GalleryCollectionViewSource.SelectedImagePath;
                    GalleryCollectionViewSource.SelectedImagePath = null;
                }
            };

            CreatePostButton.TouchUpInside += (o, e) =>
            {
                Navigator.Navigate(this, CtrConst.FeedController);
            };
        }

        public void SetBindings()
        {
            Bindings.Add(this.SetBinding
                (
                () => dataContext.Description,
                () => DescriptionTextField.Text,
                BindingMode.TwoWay
                ));
        }

        public void SetCommands()
        {
            CreatePostButton.SetCommand(dataContext.CreateCommand, this.SetBinding(() => DescriptionTextField.Text));
        }

        public void BaseStyling()
        {
        }

        public void EventStyling()
        {
        }
    }
}
