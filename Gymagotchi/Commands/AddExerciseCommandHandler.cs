using Gymagotchi.Interfaces;
using Gymagotchi.Models;
using System;

namespace Gymagotchi.Commands
{
    public class AddExerciseCommandHandler : IHandleCommand<AddExerciseCommand>
    {
        private readonly IExerciseRepository _exerciseRepository;

        public AddExerciseCommandHandler(IExerciseRepository exerciseRepository)
        {
            _exerciseRepository = exerciseRepository;
        }

        public async void Handle(AddExerciseCommand command)
        {
            try
            {
                var exercise = new Exercise(
                        command.Name,
                        command.Desc,
                        command.ExerciseCategoryDto.Id,
                        command.ExerciseModeDto.Id
                        );
                await _exerciseRepository.AddExerciseAsync(exercise);
            }
            catch
            {
                Console.WriteLine("Error");
                //TODO throw own Exception
            }
        }
    }
}
