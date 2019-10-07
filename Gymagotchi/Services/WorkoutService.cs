using Gymagotchi.Commands;
using Gymagotchi.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Gymagotchi.Services
{
    public class WorkoutService : IWorkoutService
    {
        private readonly IWorkoutRepository _workoutRepository;

        public WorkoutService(IWorkoutRepository workoutRepository)
        {
            _workoutRepository = workoutRepository;
        }

        public void AddWorkout(AddWorkoutCommand command)
        {
            _workoutRepository.AddWorkout(command);
        }
    }
}
