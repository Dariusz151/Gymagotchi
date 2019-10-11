using System;

namespace Gymagotchi.Models
{
    public class Exercise
    {
        public Guid Id { get; private set; }
        public string Name { get; private set; }
        public string Desc { get; private set; }
        public ExerciseCategory ExerciseCategory { get; private set; }
        public ExerciseMode ExerciseMode { get; private set; }

        public Exercise(string name, string desc, ExerciseCategory exerciseCategory, ExerciseMode exerciseMode)
        {
            Id = Guid.NewGuid();
            Name = name;
            Desc = desc;
            ExerciseMode = exerciseMode;
            ExerciseCategory = exerciseCategory;
        }

        public void SetId(Guid id)
        {
            Id = id;
        }

        private Exercise()
        {

        }
    }
}
