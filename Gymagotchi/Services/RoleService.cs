using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Gymagotchi.Data;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace Gymagotchi.Services
{
    public class RoleService : IRoleService
    {
        private readonly ApplicationDbContext _context;

        public RoleService(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<IdentityRole>> GetAllRoles()
        {
            return await _context.Roles.ToListAsync();
        }
    }
}
