using Microsoft.AspNetCore.Identity;
using System.Threading.Tasks;

namespace Gymagotchi.Services
{
    public interface IUserService
    {
        Task DeleteUserAsync(string userId);
        Task<IdentityUser> GetUserAsync(string userId);
    }
}
