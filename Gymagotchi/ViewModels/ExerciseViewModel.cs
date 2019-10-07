using Gymagotchi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Gymagotchi.ViewModels
{
    public class ExerciseViewModel
    {
        public string Name { get; set; }
        public string Desc { get; set; }
        public ExerciseCategory ExerciseCategory { get; set; }
        public ExerciseMode ExerciseMode { get; set; }

        public ExerciseViewModel()
        {

        }
    }
}
