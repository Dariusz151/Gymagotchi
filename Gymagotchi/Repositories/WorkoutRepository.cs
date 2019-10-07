using Gymagotchi.Commands;
using Gymagotchi.Data;
using Gymagotchi.Interfaces;
using Gymagotchi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Gymagotchi.Repositories
{
    public class WorkoutRepository : IWorkoutRepository
    {
        private readonly ApplicationDbContext _context;

        public WorkoutRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public void AddWorkout(AddWorkoutCommand command)
        {
            var exercisePullUp = new Exercise("Pull-up", "Pull up exercise desc", ExerciseCategory.Back, ExerciseMode.Narrow);
            var exercisePushUp = new Exercise("Push-up", "Push up exercise desc", ExerciseCategory.Chest, ExerciseMode.Wide);
            var exerciseDips = new Exercise("Dips", "Dips exercise desc", ExerciseCategory.Triceps, ExerciseMode.Wide);

            var exerciseSet1 = new ExerciseSet(exercisePullUp, 10, 4, 0.0f);
            var exerciseSet2 = new ExerciseSet(exercisePushUp, 8, 3, 0.0f);
            var exerciseSet3 = new ExerciseSet(exerciseDips, 14, 3, 0.0f);

            var exercisesList = new List<ExerciseSet>();
            exercisesList.Add(exerciseSet1);
            exercisesList.Add(exerciseSet2);
            exercisesList.Add(exerciseSet3);

            var workout = Workout.Create(command.UserId, "Trening1", exercisesList, DateTime.Now);
            
            _context.Workouts.Add(workout);
            _context.SaveChanges();
        }
    }
}
