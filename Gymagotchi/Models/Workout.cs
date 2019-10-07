using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Gymagotchi.Models
{
    public class Workout
    {
        public Guid Id { get; set; }
        public Guid UserId { get; set; }
        public string Description { get; set; }
        public List<ExerciseSet> Exercises { get; set; }
        public DateTime ExecutedAt { get; set; }

        private Workout()
        {

        }

        private Workout(Guid userId, string desc, List<ExerciseSet> exercises, DateTime executedAt)
        {
            this.Id = Guid.NewGuid();
            this.UserId = userId;
            this.Description = desc;
            this.Exercises = exercises;
            this.ExecutedAt = executedAt;
        }

        public static Workout Create(Guid userId, string desc, List<ExerciseSet> exercises, DateTime executedAt)
        {
            return new Workout(userId, desc, exercises, executedAt);
        }
    }
}
