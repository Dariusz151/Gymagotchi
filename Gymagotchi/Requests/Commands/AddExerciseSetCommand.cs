using Gymagotchi.Models;
using Gymagotchi.Requests.Common;
using System;

namespace Gymagotchi.Requests.Commands
{
    public class AddExerciseSetCommand : ICommand
    {
        public Guid ExerciseId { get; set; }
        public int Repeats { get; set; }
        public int SetsAmount { get; set; }
        public float Load { get; set; }
        public DateTime Timestamp { get; set; }

        public AddExerciseSetCommand(Guid exerciseId, int repeats, int setsAmount, float load, DateTime timestamp)
        {
            ExerciseId = exerciseId;
            Repeats = repeats;
            SetsAmount = setsAmount;
            Load = load;
            Timestamp = timestamp;
        }
    }
}
