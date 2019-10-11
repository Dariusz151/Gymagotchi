using Gymagotchi.Interfaces;
using Gymagotchi.Models;
using Gymagotchi.Requests.Common;
using System;

namespace Gymagotchi.Commands
{
    public class AddExerciseCommandHandler : ICommandHandler<AddExerciseCommand>
    {
        private readonly IExerciseRepository _exerciseRepository;

        public AddExerciseCommandHandler(IExerciseRepository exerciseRepository)
        {
            _exerciseRepository = exerciseRepository;
        }

        public void Handle(AddExerciseCommand command)
        {
            var exerciseCategory = _exerciseRepository.GetExerciseCategory(command.ExerciseCategoryId);
            var exerciseMode = _exerciseRepository.GetExerciseMode(command.ExerciseModeId);
           
            try
            {
                var exercise = new Exercise(
                        command.Name,
                        command.Desc,
                        exerciseCategory,
                        exerciseMode
                        );
                _exerciseRepository.AddExercise(exercise);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
                //TODO throw own Exception
            }
        }
    }
}
