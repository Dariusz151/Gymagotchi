using Dapper;
using Gymagotchi.Data;
using Gymagotchi.Dtos;
using Gymagotchi.Requests.Common;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Gymagotchi.Controllers.Api
{
    [Authorize(Roles = "Admin")]
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly ICommandsBus _commandsBus;
        private readonly ISqlConnectionFactory _sqlConnectionFactory;

        public UserController(ICommandsBus commandsBus, ISqlConnectionFactory sqlConnectionFactory)
        {
            _commandsBus = commandsBus;
            _sqlConnectionFactory = sqlConnectionFactory;
        }

        [HttpGet]
        [ActionName("")]
        public async Task<IActionResult> GetUsers()
        {
            var connection = this._sqlConnectionFactory.GetOpenConnection();
            const string sql = "SELECT " +
                               "[Users].[UserId], " +
                               "[Users].[UserName], " +
                               "[Users].[Email], " +
                               "[Users].[Role] " +
                               "FROM [GymagotchiDB].[dbo].[v_Users] as [Users] ";
            var users = await connection.QueryAsync<UserDto>(sql);

            return Ok(users);
        }
    }
}
