using Gymagotchi.Data;
using Gymagotchi.Repositories.Interfaces;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Gymagotchi.Repositories
{
    public class UserRepository : IUserRepository
    {
        private readonly ApplicationDbContext _context;

        public UserRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public IdentityUser GetUserById(Guid id)
        {
            return _context.Users.SingleOrDefault(u => u.Id == id.ToString());
        }
    }
}
