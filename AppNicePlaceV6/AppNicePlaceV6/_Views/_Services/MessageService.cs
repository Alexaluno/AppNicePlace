using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppNicePlaceV6._Views._Services
{
    public class MessageService : _ViewModels._Services.IMessageService
    {
        #region IMessageService implementation

        public async System.Threading.Tasks.Task ShowAsync(string message)
        {
            await AppNicePlaceV6.App.Current.MainPage.DisplayAlert("Nice Place", message, "ok");
        }

        #endregion

        public MessageService()
        {
        }
    }
}
