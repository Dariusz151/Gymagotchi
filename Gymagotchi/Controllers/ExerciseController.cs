using Dapper;
using Gymagotchi.Commands;
using Gymagotchi.Data;
using Gymagotchi.Dtos;
using Gymagotchi.Interfaces;
using Gymagotchi.Models;
using Gymagotchi.Requests.Common;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace Gymagotchi.Controllers
{
    public class ExerciseController : Controller
    {
        private readonly ICommandsBus _commandsBus;
        private readonly ISqlConnectionFactory _sqlConnectionFactory;

        public ExerciseController(ICommandsBus commandsBus, ISqlConnectionFactory sqlConnectionFactory)
        {
            _commandsBus = commandsBus;
            _sqlConnectionFactory = sqlConnectionFactory;
        }
        
        [Authorize(Roles = "Admin, Moderator")]
        public async Task<IActionResult> ExerciseConfig()
        {
            var connection = this._sqlConnectionFactory.GetOpenConnection();
            const string sql = "SELECT " +
                               "[Exercises].[Id], " +
                               "[Exercises].[Name], " +
                               "[Exercises].[Desc], " +
                               "[Exercises].[Category], " +
                               "[Exercises].[Mode] " +
                               "FROM [dbo].[v_Exercises] AS [Exercises] ";
            var exercises = await connection.QueryAsync<ExerciseDto>(sql);
            
            return View("ExerciseConfig", exercises);
        }
    }
}