using Gymagotchi.Models;
using System;
using System.Collections.Generic;

namespace Gymagotchi.Repositories.Interfaces
{
    public interface IExerciseSetRepository
    {
        IList<ExerciseSet> GetExerciseSetsByUser(Guid userId);
        void AddExerciseSet(ExerciseSet exerciseSet);
        void DeleteExerciseSetById(Guid id);
        void UpdateExerciseSet(ExerciseSet exerciseSet);
        ExerciseSet GetExerciseSetById(Guid id);
    }
}
