using Gymagotchi.Models;
using System;

namespace Gymagotchi.Repositories.Interfaces
{
    public interface IExerciseSetRepository
    {
        void AddExerciseSet(ExerciseSet exerciseSet);
        void DeleteExerciseSetById(Guid id);
        void UpdateExerciseSet(ExerciseSet exerciseSet);
        ExerciseSet GetExerciseSetById(Guid id);
    }
}
