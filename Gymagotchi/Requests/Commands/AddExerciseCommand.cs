using Gymagotchi.Dtos;
using Gymagotchi.Requests.Common;

namespace Gymagotchi.Commands
{
    public class AddExerciseCommand : ICommand
    {
        public string Name { get; set; }
        public string Desc { get; set; }
        public int ExerciseCategoryId { get; set; }
        public int ExerciseModeId { get; set; }

        public AddExerciseCommand(string name, string desc, int category, int mode)
        {
            Name = name;
            Desc = desc;
            ExerciseCategoryId = category;
            ExerciseModeId = mode;
        }
    }
}
