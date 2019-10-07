using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Gymagotchi.ViewModels
{
    public class ExerciseSetViewModel
    {
        public ExerciseViewModel Exercise { get; set; }
        public int Repeats { get; set; }
        public int SetsAmount { get; set; }
        public float Load { get; set; }

        public ExerciseSetViewModel()
        {

        }
    }
}
