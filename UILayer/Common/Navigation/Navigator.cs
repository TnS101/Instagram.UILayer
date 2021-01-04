using UIKit;

namespace UILayer.UILayer.Common.Navigation
{
    public class Navigator : UIViewController
    {
        public static void Navigate(UIViewController sender, string targetName)
        {
            if (nameof(sender) != targetName)
            {
                var storyboard = UIStoryboard.FromName("Main", null);

                var targetController = storyboard.InstantiateViewController(targetName);

                sender.ShowViewController(targetController, sender);
            }
        }
    }
}
