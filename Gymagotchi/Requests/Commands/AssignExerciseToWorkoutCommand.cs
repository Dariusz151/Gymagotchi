using Gymagotchi.Models;
using Gymagotchi.Requests.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Gymagotchi.Requests.Commands
{
    public class AssignExerciseToWorkoutCommand : ICommand
    {
        public List<Guid> Exercises { get; set; }
        public Guid UserId { get; set; }
        public string Description { get; set; }
        public DateTime ExecutedAt { get; set; }

        public AssignExerciseToWorkoutCommand(List<Guid> exercises, string description, Guid userId, DateTime executedAt)
        {
            Exercises = exercises;
            Description = description;
            UserId = userId;
            ExecutedAt = executedAt;
        }
    }
}
