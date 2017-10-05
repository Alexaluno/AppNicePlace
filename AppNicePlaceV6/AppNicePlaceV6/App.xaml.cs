using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace AppNicePlaceV6
{
    public partial class App : Application
    {
        public App()
        {
            DependencyService.Register<_ViewModels._Services.IMessageService, _Views._Services.MessageService>();
            DependencyService.Register<_ViewModels._Services.INavigationService, _Views._Services.NavigationService>();

            // The root page of your application
            MainPage = new NavigationPage(new _Views.LoginView());
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
