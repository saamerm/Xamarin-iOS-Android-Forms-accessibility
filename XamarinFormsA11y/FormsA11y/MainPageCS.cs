using System;

using Xamarin.Forms;

namespace FormsA11y
{
    public class MainPageCS : ContentPage
    {
        public MainPageCS()
        {
            var x = new Label
            {
                Text = "This is a label!",
                HorizontalOptions = LayoutOptions.Center,
                VerticalOptions = LayoutOptions.CenterAndExpand
            };

            // Might have to add Internet permissions to Android project Settings->Application-Permissions, in order to show the image
            var y = new Image
            {
                Source = "https://alexdunndev.files.wordpress.com/2017/02/xamarintips.png",
                HorizontalOptions = LayoutOptions.Center,
                VerticalOptions = LayoutOptions.CenterAndExpand
            };
            var z = new Button
            {
                Text = "This is a button!",
                BorderWidth = 0.5,
                WidthRequest = 300,
                HorizontalOptions = LayoutOptions.Center,
                VerticalOptions = LayoutOptions.CenterAndExpand
            };

            // Accessibility changes
            AutomationProperties.SetHelpText(x, "Picture");
            AutomationProperties.SetName(y, "Light bulb");
            AutomationProperties.SetIsInAccessibleTree(z, false);
            Content = new StackLayout
            {
                Children = { x, y, z }
            };
        }
    }
}

