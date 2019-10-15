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
using Gymagotchi.Requests.Commands;

namespace Gymagotchi.Controllers.Api
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class ExerciseSetController : ControllerBase
    {
        private readonly ICommandsBus _commandsBus;
        private readonly ISqlConnectionFactory _sqlConnectionFactory;

        public ExerciseSetController(ICommandsBus commandsBus, ISqlConnectionFactory sqlConnectionFactory)
        {
            _commandsBus = commandsBus;
            _sqlConnectionFactory = sqlConnectionFactory;
        }

        [HttpGet]
        [ActionName("")]
        public async Task<IActionResult> GetExerciseSets()
        {
            var connection = this._sqlConnectionFactory.GetOpenConnection();
            const string sql = @"SELECT 
	                               [Id]
                                  ,[Name]
                                  ,[Desc]
                                  ,[Category]
                                  ,[Mode]
                                  ,[Repeats]
                                  ,[SetsAmount]
                                  ,[Load]
                                  ,[Timestamp]
                              FROM [dbo].[v_ExerciseSets]";
            var exerciseSets = await connection.QueryAsync<ExerciseSetDto>(sql);

            return Ok(exerciseSets);
        }

        [HttpPost]
        [ActionName("Add")]
        public IActionResult AddExercise([FromBody] AddExerciseSetCommand command)
        {
            _commandsBus.Send(command);

            return Ok();
        }

        //[HttpPut]
        //[ActionName("Update")]
        //public IActionResult UpdateExercise([FromBody] UpdateExerciseCommand command)
        //{
        //    _commandsBus.Send(command);

        //    return Ok();
        //}

        //[HttpDelete]
        //[ActionName("Delete")]
        //public IActionResult DeleteExercise([FromBody] DeleteExerciseCommand command)
        //{
        //    _commandsBus.Send(command);

        //    return NoContent();
        //}
    }
}
