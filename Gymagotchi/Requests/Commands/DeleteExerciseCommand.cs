using Gymagotchi.Requests.Common;
using System;

namespace Gymagotchi.Commands
{
    public class DeleteExerciseCommand : ICommand
    {
        public Guid Id { get; set; }

        public DeleteExerciseCommand()
        {

        }
    }
}
