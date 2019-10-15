using System;

namespace Gymagotchi.Dtos
{
    public class ExerciseDto
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Desc { get; set; }
        public string Category { get; set; }
        public string Mode { get; set; }

        public ExerciseDto()
        {

        }
    }
}
