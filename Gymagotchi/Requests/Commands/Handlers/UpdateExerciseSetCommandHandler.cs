using Gymagotchi.Interfaces;
using Gymagotchi.Models;
using Gymagotchi.Repositories.Interfaces;
using Gymagotchi.Requests.Common;

namespace Gymagotchi.Commands.Handlers
{
    public class UpdateExerciseSetCommandHandler : ICommandHandler<UpdateExerciseSetCommand>
    {
        private readonly IExerciseSetRepository _exerciseSetRepository;
        private readonly IExerciseRepository _exerciseRepository;

        public UpdateExerciseSetCommandHandler(IExerciseSetRepository exerciseSetRepository, IExerciseRepository exerciseRepository)
        {
            _exerciseSetRepository = exerciseSetRepository;
            _exerciseRepository = exerciseRepository;
        }

        public void Handle(UpdateExerciseSetCommand command)
        {
            //var exercise = _exerciseRepository.GetExerciseById(command.ExerciseId);

            //var newExerciseSet = new ExerciseSet(exercise, command.Repeats, command.SetsAmount, command.Load, command.Timestamp);
            //newExerciseSet.SetId(command.Id);
            //_exerciseSetRepository.UpdateExerciseSet(newExerciseSet);
        }
    }
}
