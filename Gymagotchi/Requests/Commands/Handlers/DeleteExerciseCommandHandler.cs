using Gymagotchi.Interfaces;
using Gymagotchi.Requests.Common;
using System;

namespace Gymagotchi.Commands.Handlers
{
    public class DeleteExerciseCommandHandler : ICommandHandler<DeleteExerciseCommand>
    {
        private readonly IExerciseRepository _exerciseRepository;

        public DeleteExerciseCommandHandler(IExerciseRepository exerciseRepository)
        {
            _exerciseRepository = exerciseRepository;
        }
        public void Handle(DeleteExerciseCommand command)
        {
            _exerciseRepository.DeleteExerciseById(command.Id);
        }
    }
}
