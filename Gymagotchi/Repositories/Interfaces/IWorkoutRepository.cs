using Gymagotchi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Gymagotchi.Repositories.Interfaces
{
    public interface IWorkoutRepository
    {
        void AddWorkout(Workout workout);
    }
}
