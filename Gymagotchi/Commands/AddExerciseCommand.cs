using Gymagotchi.Dtos;

namespace Gymagotchi.Commands
{
    public class AddExerciseCommand : ICommand
    {
        public string Name { get; set; }
        public string Desc { get; set; }
        public ExerciseCategoryDto ExerciseCategoryDto { get; set; }
        public ExerciseModeDto ExerciseModeDto { get; set; }

        public AddExerciseCommand(string name, string desc, ExerciseCategoryDto category, ExerciseModeDto mode)
        {
            Name = name;
            Desc = desc;
            ExerciseCategoryDto = category;
            ExerciseModeDto = mode;
        }
    }
}
