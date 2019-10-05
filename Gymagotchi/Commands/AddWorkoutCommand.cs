using Gymagotchi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Gymagotchi.Commands
{
    public class AddWorkoutCommand : ICommand
    {
        public Guid UserId { get; set; }
        public string Description { get; set; }
        public List<ExerciseCollections> Exercises { get; set; }
        public DateTime ExecutedAt { get; set; }
    }
}
