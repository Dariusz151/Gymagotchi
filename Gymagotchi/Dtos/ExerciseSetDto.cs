using System;

namespace Gymagotchi.Dtos
{
    public class ExerciseSetDto
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Desc { get; set; }
        public string Category { get; set; }
        public string Mode { get; set; }
        public int Repeats { get; set; }
        public int SetsAmount { get; set; }
        public float Load { get; set; }
        public DateTime Timestamp { get; set; }

        public ExerciseSetDto()
        {

        }
    }
}
