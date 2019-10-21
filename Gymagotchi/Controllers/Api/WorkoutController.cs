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
        public IActionResult AssignToWorkoutWorkout([FromBody] AssignExerciseToWorkoutCommand command)
        {
            _commandsBus.Send(command);

            return Ok();
        }
    }
}
