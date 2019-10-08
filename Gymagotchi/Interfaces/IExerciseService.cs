using Gymagotchi.Commands;
using Gymagotchi.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Gymagotchi.Interfaces
{
    public interface IExerciseService
    {
        Task<bool> AddExerciseAsync(AddExerciseCommand command);
        IEnumerable<ExerciseCategory> GetExerciseCategories();
        IEnumerable<ExerciseMode> GetExerciseModes();
    }
}
