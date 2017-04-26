using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Azure.Mobile;
using Microsoft.Azure.Mobile.Analytics;
using Microsoft.Azure.Mobile.Crashes;
using Xamarin.Forms;
using Device = Xamarin.Forms.Device;

namespace CoolBreeze
{
    public partial class App : Application
    {
        public static MainViewModel ViewModel;
        public static string RegistrationCode = "XBWWBE3161B54E8FF05C2606431B6535";
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new CoolBreeze.StartPage());
        }

        protected override void OnStart()
        {
            // Mobile center isn't registered for UWP, so don't start it on UWP.
            if (Device.RuntimePlatform != Device.Windows)
                MobileCenter.Start(typeof(Analytics), typeof(Crashes));
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
