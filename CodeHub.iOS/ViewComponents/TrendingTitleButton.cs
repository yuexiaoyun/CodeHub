﻿using MonoTouch.UIKit;

namespace CodeHub.iOS.ViewComponents
{
    public class TrendingTitleButton : UIButton
    {
        private readonly UILabel _label;
        private readonly UIImageView _imageView;

        public string Text
        {
            get { return _label.Text; }
            set 
            { 
                _label.Text = value;
                SetNeedsLayout();
            }
        }

        public UIColor TintColor
        {
            get { return _label.TextColor; }
            set 
            { 
                _label.TextColor = value; 
                _imageView.TintColor = value;
            }
        }

        public TrendingTitleButton()
        {
            _label = new UILabel();
            _label.TextAlignment = UITextAlignment.Center;
            Add(_label);

            _imageView = new UIImageView();
            _imageView.Frame = new System.Drawing.RectangleF(0, 0, 12, 12);
            _imageView.Image = Images.DownChevron.ImageWithRenderingMode(UIImageRenderingMode.AlwaysTemplate);
            Add(_imageView);
        }

        public override void LayoutSubviews()
        {
            base.LayoutSubviews();

            _label.SizeToFit();
            _label.Center = new System.Drawing.PointF(Frame.Width / 2f, Frame.Height / 2f);
            _imageView.Center = new System.Drawing.PointF(_label.Frame.Right + 12f, Frame.Height / 2f);
        }
    }
}

