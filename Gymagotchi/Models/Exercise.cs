using System;

namespace Gymagotchi.Models
{
    public class Exercise
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Desc { get; set; }
        public ExerciseCategory ExerciseCategory { get; set; }
        public ExerciseMode ExerciseMode { get; set; }

        public Exercise(string name, string desc, ExerciseCategory exerciseCategory, ExerciseMode exerciseMode)
        {
            Id = Guid.NewGuid();
            Name = name;
            Desc = desc;
            ExerciseMode = ExerciseMode;
            ExerciseCategory = exerciseCategory;
        }
        public Exercise()
        {

        }
    }

    public enum ExerciseCategory
    {
        Biceps,
        Triceps,
        Back,
        Chest
    }

    public enum ExerciseMode
    {
        Narrow,
        Middle,
        Wide
    }
}
