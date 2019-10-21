using Gymagotchi.Interfaces;
using Gymagotchi.Models;
using Gymagotchi.Repositories.Interfaces;
using Gymagotchi.Requests.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Gymagotchi.Requests.Commands.Handlers
{
    public class AssignExerciseToWorkoutCommandHandler : ICommandHandler<AssignExerciseToWorkoutCommand>
    {
        private readonly IExerciseSetRepository _exerciseSetRepository;
        private readonly IExerciseRepository _exerciseRepository;
        private readonly IUserRepository _userRepository;
        private readonly IWorkoutRepository _workoutRepository;

        public AssignExerciseToWorkoutCommandHandler(IExerciseSetRepository exerciseSetRepository, IExerciseRepository exerciseRepository, IUserRepository userRepository, IWorkoutRepository workoutRepository)
        {
            _exerciseSetRepository = exerciseSetRepository;
            _exerciseRepository = exerciseRepository;
            _userRepository = userRepository;
            _workoutRepository = workoutRepository;
        }

        public void Handle(AssignExerciseToWorkoutCommand command)
        {
            var exercises = (List<ExerciseSet>)_exerciseSetRepository.GetExerciseSetsByUser(command.UserId);
            var workout = Workout.Create();
            workout.Description = command.Description;
            workout.Exercises = exercises;
            workout.UserId = command.UserId;

            _workoutRepository.AddWorkout(workout);

            foreach (var ex in exercises)
            {
                ex.AssignWorkout(workout);
            }
        }
    }
}
