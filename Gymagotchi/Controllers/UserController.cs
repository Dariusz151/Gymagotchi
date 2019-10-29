using Dapper;
using Gymagotchi.Data;
using Gymagotchi.Dtos;
using Gymagotchi.Requests.Commands;
using Gymagotchi.Requests.Common;
using Gymagotchi.Services;
using Gymagotchi.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
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
        private readonly IUserService _userService;
        private readonly IRoleService _roleService;

        public UserController(ICommandsBus commandsBus, ISqlConnectionFactory sqlConnectionFactory,
            IUserService userService, IRoleService roleService)
        {
            _commandsBus = commandsBus;
            _sqlConnectionFactory = sqlConnectionFactory;
            _userService = userService;
            _roleService = roleService;
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
        
        public async Task<IActionResult> Delete(string userId)
        {
            await _userService.DeleteUserAsync(userId);

            return RedirectToAction("UserConfig");
        }

        public async Task<IActionResult> Edit(string userId)
        {
            var user = await _userService.GetUserAsync(userId);

            var editUserRoleViewModel = new EditUserRoleViewModel();
            editUserRoleViewModel.UserId = user.Id;
            editUserRoleViewModel.Email = user.Email;

            var roles = await _roleService.GetAllRoles();

            editUserRoleViewModel.Roles = roles;
            
            return View("UserRoleEdit", editUserRoleViewModel);
        }
    }
}
