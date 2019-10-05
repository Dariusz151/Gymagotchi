using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Gymagotchi.Models
{
    public class Exercise
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Desc { get; set; }
        public ExerciseCategory ExerciseCategory { get; set; }
        public ExerciseMode ExerciseMode { get; set; }
    }
}
