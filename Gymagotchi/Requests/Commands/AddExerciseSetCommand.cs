using Gymagotchi.Models;
using Gymagotchi.Requests.Common;
using System;

namespace Gymagotchi.Requests.Commands
{
    public class AddExerciseSetCommand : ICommand
    {
        public Guid UserId { get; set; }
        public Guid ExerciseId { get; set; }
        public int Repeats { get; set; }
        public int SetsAmount { get; set; }
        public float Load { get; set; }
        public DateTime Timestamp { get; set; }

        public AddExerciseSetCommand(Guid userId, Guid exerciseId, int repeats, int setsAmount, float load, DateTime timestamp)
        {
            UserId = userId;
            ExerciseId = exerciseId;
            Repeats = repeats;
            SetsAmount = setsAmount;
            Load = load;
            Timestamp = timestamp;
        }
    }
}
