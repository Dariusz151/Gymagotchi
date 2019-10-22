using Gymagotchi.Commands;
using Gymagotchi.Data;
using Gymagotchi.Interfaces;
using Gymagotchi.Requests.Commands;
using Gymagotchi.Requests.Common;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Gymagotchi.Controllers.Api
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class WorkoutController : ControllerBase
    {
        private readonly ICommandsBus _commandsBus;
        private readonly ISqlConnectionFactory _sqlConnectionFactory;

        public WorkoutController(ICommandsBus commandsBus, ISqlConnectionFactory sqlConnectionFactory)
        {
            _commandsBus = commandsBus;
            _sqlConnectionFactory = sqlConnectionFactory;
        }
        
        [HttpPost]
        [ActionName("Assign")]
        public IActionResult AssignToWorkout([FromBody] AssignExerciseToWorkoutCommand command)
        {
            _commandsBus.Send(command);

            return Ok();
        }

        [HttpGet]
        [ActionName("")]
        public IActionResult GetWorkouts(Guid userId)
        {
            //var connection = this._sqlConnectionFactory.GetOpenConnection();
            //const string sql = @"SELECT
            //                       [Id]
            //                      ,[UserId]
            //                      ,[Email]
            //                      ,[Description]
            //                      ,[ExecutedAt]
            //                      ,[ExerciseId]
            //                      ,[SetsAmount]
            //                      ,[Load]
            //                      ,[Repeats]
            //                      ,[Timestamp]
            //                  FROM [GymagotchiDB].[dbo].[v_Workouts]
            //                  WHERE [UserId] = @Id";
            //var exerciseSets = await connection.QueryAsync<ExerciseSetDto>(sql);

            //return Ok(exerciseSets);

            
            return Ok();
        }
    }
}
