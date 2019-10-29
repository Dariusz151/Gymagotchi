using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Gymagotchi.ViewModels
{
    public class EditUserRoleViewModel
    {
        public string UserId { get; set; }
        public string Email { get; set; }
        public string RoleId { get; set; }
        public IEnumerable<IdentityRole> Roles { get; set; }

        public EditUserRoleViewModel()
        {

        }
    }
}
