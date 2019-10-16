using Gymagotchi.Requests.Common;
using System;

namespace Gymagotchi.Requests.Commands
{
    public class DeleteExerciseSetCommand : ICommand
    {
        public Guid Id { get; set; }
        
        public DeleteExerciseSetCommand(Guid id)
        {
            Id = id;
        }
    }
}
