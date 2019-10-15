using Gymagotchi.Commands;
using Gymagotchi.Data;
using Gymagotchi.Models;
using System.Linq;
using System.Data.Common;
using Gymagotchi.Requests.Common;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using Dapper;

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
        [ActionName("")]
        public async Task<IActionResult> GetExercises()
        {
            var connection = this._sqlConnectionFactory.GetOpenConnection();
            const string sql = "SELECT " +
                               "[Order].[Id], " +
                               "[Order].[IsRemoved], " +
                               "[Order].[Value], " +
                               "[Order].[Currency] " +
                               "FROM orders.v_Orders AS [Order] " +
                               "WHERE [Order].CustomerId = @CustomerId";
            var exercises = await connection.QueryAsync<Exercise>(sql);

            return Ok(exercises);
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
