using Gymagotchi.Commands;
using Gymagotchi.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Gymagotchi.Controllers.Api
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class ExerciseController : ControllerBase
    {
        private readonly ICommandsBus _commandsBus;
       
        public ExerciseController(ICommandsBus commandsBus)
        {
            _commandsBus = commandsBus;
        }

        [HttpPost]
        [ActionName("Add")]
        public IActionResult AddExercise([FromBody] AddExerciseCommand command)
        {
            _commandsBus.Send(command);

            return Ok();
        }

        [HttpPut]
        [ActionName("Update")]
        public IActionResult UpdateExercise([FromBody] UpdateExerciseCommand command)
        {
            _commandsBus.Send(command);

            return Ok();
        }

        [HttpDelete]
        [ActionName("Delete")]
        public IActionResult DeleteExercise([FromBody] DeleteExerciseCommand command)
        {
            _commandsBus.Send(command);

            return NoContent();
        }
    }
}
