using Gymagotchi.Models;
using System.Collections.Generic;

namespace Gymagotchi.ViewModels
{
    public class ExerciseFormViewModel
    {
        public IEnumerable<ExerciseCategory> ExerciseCategories { get; set; }
        public IEnumerable<ExerciseMode> ExerciseModes { get; set; }

        public ExerciseFormViewModel(IEnumerable<ExerciseCategory> categories, IEnumerable<ExerciseMode> modes)
        {
            ExerciseCategories = categories;
            ExerciseModes = modes;
        }

        public ExerciseFormViewModel()
        {

        }
    }
}
