using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace AppNicePlaceV6._ViewModels
{
    public class RegisterViewModel : ViewModelBase
    {
        private readonly _Services.IMessageService _messageService;
        private readonly _Services.INavigationService _navigationService;

       

        string email;
        public string Email
        {
            get
            {
                return email;
            }
            set
            {
                email = value;
                this.Notify("Email");
            }
        }

        string nome;
        public string Nome
        {
            get
            {
                return nome;
            }
            set
            {
                nome = value;
                this.Notify("Nome");
            }
        }

        string password;
        public string Password
        {
            get
            {
                return password;
            }
            set
            {
                password = value;
                this.Notify("Password");
            }
        }

        

        public ICommand RegisterCommand
        {
            get;
            set;
        }
        public RegisterViewModel()
        {
            
            this.RegisterCommand = new Command(this.Register);

            this._messageService = DependencyService.Get<_Services.IMessageService>();
            this._navigationService = DependencyService.Get<_Services.INavigationService>();
        }

        private async void Register()
        {
            await this._navigationService.NavigateToRegister();
            await this._messageService.ShowAsync("Dados registrados com sucesso!");
        }
    }
}
