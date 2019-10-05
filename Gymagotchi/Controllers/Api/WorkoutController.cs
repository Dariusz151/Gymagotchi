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
    public class WorkoutController : ControllerBase
    {
        private readonly IWorkoutService _workoutService;

        public WorkoutController(IWorkoutService workoutService)
        {
            _workoutService = workoutService;
        }

        [HttpGet]
        [ActionName("Ping")]
        public ActionResult<IEnumerable<string>> Ping()
        {
            return new string[] { "WorkoutController" };
        }

        [HttpPost]
        [ActionName("AddWorkout")]
        public IActionResult AddWorkout([FromBody] AddWorkoutCommand command)
        {
            var userId = new Guid("48577875-4D33-4543-8440-8321EB4BAAA3");
            
            _workoutService.AddWorkout(command);

            return Ok();
        }
    }
}
