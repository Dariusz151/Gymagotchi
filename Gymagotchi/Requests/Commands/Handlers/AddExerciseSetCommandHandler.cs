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
    public class AddExerciseSetCommandHandler : ICommandHandler<AddExerciseSetCommand>
    {
        private readonly IExerciseSetRepository _exerciseSetRepository;
        private readonly IExerciseRepository _exerciseRepository;

        public AddExerciseSetCommandHandler(IExerciseSetRepository exerciseSetRepository, IExerciseRepository exerciseRepository)
        {
            _exerciseSetRepository = exerciseSetRepository;
            _exerciseRepository = exerciseRepository;
        }

        public void Handle(AddExerciseSetCommand command)
        {
            var exercise = _exerciseRepository.GetExerciseById(command.ExerciseId);

            try
            {
                var exerciseSet = new ExerciseSet(
                        exercise,
                        command.Repeats,
                        command.SetsAmount,
                        command.Load,
                        command.Timestamp
                        );
                _exerciseSetRepository.AddExerciseSet(exerciseSet);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
                //TODO throw own Exception
            }
        }
    }
}
