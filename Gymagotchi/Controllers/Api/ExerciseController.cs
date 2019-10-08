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
        private readonly IExerciseService _exerciseService;

        public ExerciseController(IExerciseService exerciseService)
        {
            _exerciseService = exerciseService;
        }

        [HttpPost]
        [ActionName("Add")]
        public async Task<IActionResult> AddExercise([FromBody] AddExerciseCommand command)
        {
            await _exerciseService.AddExerciseAsync(command);

            return Ok();
        }
    }
}
