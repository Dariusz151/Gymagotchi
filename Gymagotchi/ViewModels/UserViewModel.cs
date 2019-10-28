using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Gymagotchi.ViewModels
{
    public class UserViewModel
    {
        public string UserId { get; set; }
        public string UserName { get; set; }
        public string Email { get; set; }
        public string Role { get; set; }

        public UserViewModel()
        {

        }

        public UserViewModel(string userId, string userName, string email, string role)
        {
            UserId = userId;
            UserName = UserName;
            Email = email;
            Role = role;
        }
    }
}
