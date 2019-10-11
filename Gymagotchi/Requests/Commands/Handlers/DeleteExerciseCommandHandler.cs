using Gymagotchi.Interfaces;
using System;

namespace Gymagotchi.Commands.Handlers
{
    public class DeleteExerciseCommandHandler : IHandleCommand<DeleteExerciseCommand>
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
