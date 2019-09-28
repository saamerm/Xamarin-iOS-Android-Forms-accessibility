using System;

using UIKit;

namespace A11yXamarinNative.iOS
{
    public partial class ViewController : UIViewController
    {
        int count = 1;
        public ViewController(IntPtr handle) : base(handle)
        {
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            Button.AccessibilityIdentifier = "myButton";
            Button.IsAccessibilityElement = true;
            Button.TouchUpInside += delegate
            {
                var title = string.Format("{0} clicks!", count++);
                Button.SetTitle(title, UIControlState.Normal);
                Button.AccessibilityTraits |= UIAccessibilityTrait.Selected;
                Button.AccessibilityTraits |= UIAccessibilityTrait.Button;
                UIAccessibility.PostNotification(UIAccessibilityPostNotification.Announcement, MyLabel);
            };
            MyLabel.AccessibilityLabel = "This is a label";
        }

        public override void DidReceiveMemoryWarning()
        {
            base.DidReceiveMemoryWarning();
            // Release any cached data, images, etc that aren't in use.		
        }
    }
}
