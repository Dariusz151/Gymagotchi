using Gymagotchi.Interfaces;
using Gymagotchi.Models;
using Gymagotchi.Requests.Common;

namespace Gymagotchi.Commands.Handlers
{
    public class UpdateExerciseCommandHandler : ICommandHandler<UpdateExerciseCommand>
    {
        private readonly IExerciseRepository _exerciseRepository;

        public UpdateExerciseCommandHandler(IExerciseRepository exerciseRepository)
        {
            _exerciseRepository = exerciseRepository;
        }

        public void Handle(UpdateExerciseCommand command)
        {
            var exerciseCategory = _exerciseRepository.GetExerciseCategory(command.ExerciseCategoryId);
            var exerciseMode = _exerciseRepository.GetExerciseMode(command.ExerciseModeId);
            
            var exercise = new Exercise(command.Name, command.Desc, exerciseCategory, exerciseMode);
            exercise.SetId(command.Id);
            _exerciseRepository.UpdateExercise(exercise);
        }
    }
}
