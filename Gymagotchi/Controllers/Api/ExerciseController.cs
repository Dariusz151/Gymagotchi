using Gymagotchi.Commands;
using Gymagotchi.Data;
using Gymagotchi.Models;
using System.Linq;
using System.Data.Common;
using Gymagotchi.Requests.Common;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using Dapper;
using Gymagotchi.Dtos;
using Microsoft.AspNetCore.Authorization;

namespace Gymagotchi.Controllers.Api
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class ExerciseController : ControllerBase
    {
        private readonly ICommandsBus _commandsBus;
        private readonly ISqlConnectionFactory _sqlConnectionFactory;

        public ExerciseController(ICommandsBus commandsBus, ISqlConnectionFactory sqlConnectionFactory)
        {
            _commandsBus = commandsBus;
            _sqlConnectionFactory = sqlConnectionFactory;
        }

        [HttpGet]
        [AllowAnonymous]
        [ActionName("")]
        public async Task<IActionResult> GetExercises()
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

            return Ok(exercises);
        }

        [HttpPost]
        [Authorize(Roles = "Admin, Moderator")]
        [ActionName("Add")]
        public IActionResult AddExercise([FromBody] AddExerciseCommand command)
        {
            _commandsBus.Send(command);

            return Ok();
        }
        
        [HttpPut]
        [Authorize(Roles = "Admin, Moderator")]
        [ActionName("Update")]
        public IActionResult UpdateExercise([FromBody] UpdateExerciseCommand command)
        {
            _commandsBus.Send(command);

            return Ok();
        }

        [HttpDelete]
        [Authorize(Roles = "Admin, Moderator")]
        [ActionName("Delete")]
        public IActionResult DeleteExercise([FromBody] DeleteExerciseCommand command)
        {
            _commandsBus.Send(command);

            return NoContent();
        }
    }
}
