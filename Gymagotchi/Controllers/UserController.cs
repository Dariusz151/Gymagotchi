using Dapper;
using Gymagotchi.Data;
using Gymagotchi.Dtos;
using Gymagotchi.Requests.Common;
using Gymagotchi.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Gymagotchi.Controllers
{
    [Authorize(Roles = "Admin")]
    public class UserController : Controller
    {
        private readonly ICommandsBus _commandsBus;
        private readonly ISqlConnectionFactory _sqlConnectionFactory;

        public UserController(ICommandsBus commandsBus, ISqlConnectionFactory sqlConnectionFactory)
        {
            _commandsBus = commandsBus;
            _sqlConnectionFactory = sqlConnectionFactory;
        }
        
        public async Task<IActionResult> UserConfig()
        {
            var connection = this._sqlConnectionFactory.GetOpenConnection();
            const string sql = "SELECT " +
                               "[Users].[UserId], " +
                               "[Users].[UserName], " +
                               "[Users].[Email], " +
                               "[Users].[Role] " +
                               "FROM [GymagotchiDB].[dbo].[v_Users] as [Users] ";
            var users = await connection.QueryAsync<UserDto>(sql);
            
            var usersViewModel = new List<UserViewModel>();
            foreach (var user in users)
            {
                usersViewModel.Add(new UserViewModel(
                    user.UserId, 
                    user.UserName, 
                    user.Email, 
                    user.Role));
            }
            
            return View("UserConfig", usersViewModel);
        }
    }
}
