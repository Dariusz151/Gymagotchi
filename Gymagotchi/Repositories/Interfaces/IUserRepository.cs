using Microsoft.AspNetCore.Identity;
using System;

namespace Gymagotchi.Repositories.Interfaces
{
    public interface IUserRepository
    {
        IdentityUser GetUserById(Guid id);
    }
}
