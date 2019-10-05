using Gymagotchi.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Gymagotchi.Interfaces
{
    public interface IWorkoutRepository
    {
        void AddWorkout(AddWorkoutCommand command);
    }
}
