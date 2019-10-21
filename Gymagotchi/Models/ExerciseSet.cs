using Microsoft.AspNetCore.Identity;
using System;

namespace Gymagotchi.Models
{
    public class ExerciseSet
    {
        public Guid Id { get; set; }

        public IdentityUser User { get; set; }

        public Exercise Exercise { get; set; }

        public Workout Workout { get; set; }

        public int Repeats { get; set; }

        public int SetsAmount { get; set; }

        public float Load { get; set; }

        public DateTime Timestamp { get; set; }

        public void SetId(Guid id)
        {
            Id = id;
        }

        public void AssignWorkout(Workout workout)
        {
            Workout = workout;
        }

        public ExerciseSet(IdentityUser user, Exercise exercise, int repeats, int setsAmount, float load, DateTime timestamp)
        {
            User = user;
            Id = Guid.NewGuid();
            Exercise = exercise;
            Repeats = repeats;
            SetsAmount = setsAmount;
            Load = load;
            Timestamp = timestamp;
        }

        public ExerciseSet(IdentityUser user, Exercise exercise, int repeats, int setsAmount, float load)
        {
            new ExerciseSet(user, exercise, repeats, setsAmount, load, DateTime.Now);
        }

        private ExerciseSet()
        {

        }
    }
}
