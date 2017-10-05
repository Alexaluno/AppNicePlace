using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppNicePlaceV6._Views._Services
{
    public class NavigationService : _ViewModels._Services.INavigationService
    {
        #region INavigationService implementation

        public async System.Threading.Tasks.Task NavigateToLogin()
        {
            await AppNicePlaceV6.App.Current.MainPage.Navigation.PushAsync(new _Views.LoginView());
        }

        public async System.Threading.Tasks.Task NavigateToRegister()
        {
            await AppNicePlaceV6.App.Current.MainPage.Navigation.PushAsync(new _Views.RegisterView());
        }

        public async System.Threading.Tasks.Task NavigateToMain()
        {
            await AppNicePlaceV6.App.Current.MainPage.Navigation.PushAsync(new _Views.MainView());
        }

        #endregion

        public NavigationService()
        {
        }
    }
}