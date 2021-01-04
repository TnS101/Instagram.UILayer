using System;
using UIKit;

namespace UILayer.UILayer.Common.UI
{
    public static class Styler
    {
        public static void SetBackgroundColor(UIView view, UIColor color) => view.BackgroundColor = color;

        public static void SetTextColor(UIButton button, UIColor color, UIControlState state = UIControlState.Normal) => button.SetTitleColor(color, state);

        public static void SetTextColor(UITextField textField, UIColor color) => textField.TextColor = color;

        public static void SetTextColor(UILabel label, UIColor color) => label.TextColor = color;

        public static void SetShadows(this UIView view, UIColor color, int opacity, int radius, nfloat offsetHeight)
        {
            view.Layer.MasksToBounds = false;

            view.Layer.ShadowColor = color.CGColor;
            view.Layer.ShadowOpacity = opacity;
            view.Layer.ShadowRadius = radius;
            view.Layer.ShadowOffset = new CoreGraphics.CGSize(0f, offsetHeight);
        }

        public static void SetBorderRadius(UIView view, nfloat amount)
        {
            view.ClipsToBounds = true;
            view.Layer.CornerRadius = amount;
        }

        public static void SetBorders(UIView view, UIColor borderColor, nfloat width)
        {
            view.Layer.MasksToBounds = true;

            view.Layer.BorderColor = borderColor.CGColor;
            view.Layer.BorderWidth = width;
        }
    }
}
