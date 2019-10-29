using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Gymagotchi.Services
{
    public interface IRoleService
    {
        Task<IEnumerable<IdentityRole>> GetAllRoles();
    }
}
