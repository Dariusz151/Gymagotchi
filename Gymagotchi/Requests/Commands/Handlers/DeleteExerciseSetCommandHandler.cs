using Gymagotchi.Repositories.Interfaces;
using Gymagotchi.Requests.Common;

namespace Gymagotchi.Requests.Commands.Handlers
{
    public class DeleteExerciseSetCommandHandler : ICommandHandler<DeleteExerciseSetCommand>
    {
        private readonly IExerciseSetRepository _exerciseSetRepository;
     
        public DeleteExerciseSetCommandHandler(IExerciseSetRepository exerciseSetRepository)
        {
            _exerciseSetRepository = exerciseSetRepository;
        }

        public void Handle(DeleteExerciseSetCommand command)
        {
            _exerciseSetRepository.DeleteExerciseSetById(command.Id);
        }
    }
}
