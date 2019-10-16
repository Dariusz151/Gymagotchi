using Gymagotchi.Requests.Common;
using System;

namespace Gymagotchi.Commands
{
    public class UpdateExerciseSetCommand : ICommand
    {
        public Guid Id { get; set; }
        public Guid ExerciseId { get; set; }
        public int Repeats { get; set; }
        public int SetsAmount { get; set; }
        public float Load { get; set; }
        public DateTime Timestamp { get; set; }

        public UpdateExerciseSetCommand(Guid id, Guid exerciseId, int repeats, int setsAmount, float load, DateTime timestamp)
        {
            Id = id;
            ExerciseId = exerciseId;
            Repeats = repeats;
            SetsAmount = setsAmount;
            Load = load;
            Timestamp = timestamp;
        }
    }
}
