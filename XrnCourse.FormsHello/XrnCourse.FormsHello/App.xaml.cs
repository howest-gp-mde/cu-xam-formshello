using System;
using System.Diagnostics;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XrnCourse.FormsHello
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new MainPage());
        }

        protected override void OnStart()
        {
            // Handle when your app starts
            Debug.WriteLine($"{DateTime.Now} - App meets world");
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
            Debug.WriteLine($"{DateTime.Now} - ZzzZzz");
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
            Debug.WriteLine($"{DateTime.Now} - Wake up and smell the coffee");
        }
    }
}
