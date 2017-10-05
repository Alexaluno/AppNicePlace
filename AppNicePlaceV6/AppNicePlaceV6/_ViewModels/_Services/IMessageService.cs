using System.Threading.Tasks;

namespace AppNicePlaceV6._ViewModels._Services
{
    public interface IMessageService
    {
        Task ShowAsync(string message);
    }
}
