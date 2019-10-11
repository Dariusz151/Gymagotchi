using Gymagotchi.Models;
using Gymagotchi.Requests.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Gymagotchi.Requests.Queries.Handlers
{
    public class GetExerciseHandler : IQueryHandler<GetExerciseQuery, Exercise>
    {
        public Task<Exercise> HandleAsync(GetExerciseQuery query)
        {
            throw new NotImplementedException();
        }
    }
}
