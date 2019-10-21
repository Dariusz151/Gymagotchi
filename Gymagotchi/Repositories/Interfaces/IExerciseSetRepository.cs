using Gymagotchi.Models;
using System;
using System.Collections.Generic;

namespace Gymagotchi.Repositories.Interfaces
{
    public interface IExerciseSetRepository
    {
        List<ExerciseSet> GetExerciseSets(List<Guid> exerciseSetsIds);
        void AssignWorkout(List<Guid> exerciseSetsIds, Workout workout);
        void AddExerciseSet(ExerciseSet exerciseSet);
        void DeleteExerciseSetById(Guid id);
        void UpdateExerciseSet(ExerciseSet exerciseSet);
        ExerciseSet GetExerciseSetById(Guid id);
    }
}
