using System;

namespace Gymagotchi.Models
{
    public class Exercise
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Desc { get; set; }

        public int ExerciseCategoryId { get; set; }
        public int ExerciseModeId { get; set; }

        public ExerciseCategory ExerciseCategory { get; set; }
        public ExerciseMode ExerciseMode { get; set; }

        public Exercise(string name, string desc, int exerciseCategoryId, int exerciseModeId)
        {
            Id = Guid.NewGuid();
            Name = name;
            Desc = desc;
            ExerciseModeId = exerciseModeId;
            ExerciseCategoryId = exerciseCategoryId;
        }
        public Exercise()
        {

        }
    }
}
