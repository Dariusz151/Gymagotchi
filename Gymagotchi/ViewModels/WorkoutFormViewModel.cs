using Gymagotchi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Gymagotchi.ViewModels
{
    public class WorkoutFormViewModel
    {
        public Guid UserId { get; set; }
        public string Description { get; set; }
        public IEnumerable<ExerciseSetViewModel> Exercises { get; set; }
        public DateTime ExecutedAt { get; set; }

        public WorkoutFormViewModel()
        {

        }
    }
}
