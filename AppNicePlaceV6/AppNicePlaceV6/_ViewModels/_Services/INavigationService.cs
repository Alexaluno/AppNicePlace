using System.Threading.Tasks;

namespace AppNicePlaceV6._ViewModels._Services
{
    public interface INavigationService
    {
        Task NavigateToLogin();
        Task NavigateToRegister();
        Task NavigateToMain();
    }
}
