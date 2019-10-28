using System.Threading.Tasks;

namespace Gymagotchi.Services
{
    public interface IUserService
    {
        Task DeleteUserAsync(string userId);
    }
}
