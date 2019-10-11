using System;

namespace Gymagotchi.Models
{
    public class ExerciseSet
    {
        public Guid Id { get; set; }
        public Exercise Exercise { get; set; }
        public int Repeats { get; set; }
        public int SetsAmount { get; set; }
        public float Load { get; set; }

        public ExerciseSet(Exercise exercise, int repeats, int setsAmount, float load)
        {
            Id = Guid.NewGuid();
            Exercise = exercise;
            Repeats = repeats;
            SetsAmount = setsAmount;
            Load = load;
        }
        public ExerciseSet()
        {

        }
    }
}
