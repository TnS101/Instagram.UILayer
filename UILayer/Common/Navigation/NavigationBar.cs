using UIKit;

namespace UILayer.UILayer.Common.Navigation
{
    public class NavigationBar
    {
        public static void Set(UIViewController sender, UIButton homeButton, UIButton friendsButton, UIButton addPostButton, UIButton profileButton)
        {
            homeButton.TouchUpInside += (o, e) =>
            {
                Navigator.Navigate(sender, CtrConst.FeedController);
            };

            friendsButton.TouchUpInside += (o, e) =>
            {
                Navigator.Navigate(sender, CtrConst.FollowersController);
            };

            addPostButton.TouchUpInside += (o, e) =>
            {
                Navigator.Navigate(sender, CtrConst.PostController);
            };

            profileButton.TouchUpInside += (o, e) =>
            {
                Navigator.Navigate(sender, CtrConst.ProfileController);
            };
        }
    }
}
