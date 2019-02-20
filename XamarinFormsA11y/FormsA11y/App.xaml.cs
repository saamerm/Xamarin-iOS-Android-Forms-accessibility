using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace FormsA11y
{
    public partial class App : Application
    {
        public App()
        {
            // Was not able to get accessibility to work through XAML based on what was given here
            // https://docs.microsoft.com/en-us/xamarin/xamarin-forms/app-fundamentals/accessibility/automation-properties
            // as Intellisense doesnt recognise it, and we get a build error
            //InitializeComponent();
            MainPage = new MainPageXAML();

            // Used the AutomationProperties class 
            //MainPage = new MainPageCS();
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
