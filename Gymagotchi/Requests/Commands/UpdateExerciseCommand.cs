using Gymagotchi.Requests.Common;
using System;

namespace Gymagotchi.Commands
{
    public class UpdateExerciseCommand : ICommand
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Desc { get; set; }
        public int ExerciseCategoryId { get; set; }
        public int ExerciseModeId { get; set; }

        public UpdateExerciseCommand(Guid id, string name, string desc, int category, int mode)
        {
            Id = id;
            Name = name;
            Desc = desc;
            ExerciseCategoryId = category;
            ExerciseModeId = mode;
        }
    }
}
