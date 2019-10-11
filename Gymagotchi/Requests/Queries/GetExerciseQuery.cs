
using Gymagotchi.Models;
using Gymagotchi.Requests.Common;
using System;

namespace Gymagotchi.Requests.Queries
{
    public class GetExerciseQuery : IQuery<Exercise>
    {
        public Guid Id { get; set; }
        public GetExerciseQuery()
        {

        }
    }
}
