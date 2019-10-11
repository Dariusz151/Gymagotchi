using Gymagotchi.Models;
using System;
using System.Collections;
using System.Collections.Generic;

namespace Gymagotchi.Interfaces
{
    public interface IExerciseRepository
    {
        IEnumerable<Exercise> GetExercises();
        Exercise GetExerciseById(Guid id);
        void DeleteExerciseById(Guid id);
        void UpdateExercise(Exercise exercise);
        void AddExercise(Exercise exercise);
        ExerciseCategory GetExerciseCategory(int exerciseCategoryId);
        ExerciseMode GetExerciseMode(int exerciseModeId);
    }
}
