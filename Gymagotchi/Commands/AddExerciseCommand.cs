using Gymagotchi.Models;

namespace Gymagotchi.Commands
{
    public class AddExerciseCommand : ICommand
    {
        public string Name { get; set; }
        public string Desc { get; set; }
        public ExerciseCategory ExerciseCategory { get; set; }
        public ExerciseMode ExerciseMode { get; set; }

        public AddExerciseCommand(string name, string desc, ExerciseCategory category, ExerciseMode mode)
        {
            Name = name;
            Desc = desc;
            ExerciseCategory = category;
            ExerciseMode = mode;
        }
    }
}
