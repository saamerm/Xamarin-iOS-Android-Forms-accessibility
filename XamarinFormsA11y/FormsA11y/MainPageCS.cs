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
                Text = "Welcome to Xamarin.Forms!",
                HorizontalOptions = LayoutOptions.Center,
                VerticalOptions = LayoutOptions.CenterAndExpand
            };

            // Had to add Internet permissions to Android project Settings->Application-Permissions, in order to show the image
            var y = new Image
            {
                Source = "https://alexdunndev.files.wordpress.com/2017/02/xamarintips.png",
                HorizontalOptions = LayoutOptions.Center,
                VerticalOptions = LayoutOptions.CenterAndExpand
            };
            var z = new Button
            {
                Text = "Welcome to Xamarin.Forms!",
                HorizontalOptions = LayoutOptions.Center,
                VerticalOptions = LayoutOptions.CenterAndExpand
            };

            Content = new StackLayout
            {
                Children = { x, y, z }
            };
        }
    }
}

