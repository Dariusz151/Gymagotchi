using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Gymagotchi.Models
{
    public class Avatar
    {
        public string Name { get; set; }
        public Decimal Weight { get; set; }
        public Decimal Height { get; set; }
        public List<Muscle> LeftArm { get; set; }
        public List<Muscle> RightArm { get; set; }
        public List<Muscle> LeftLeg { get; set; }
        public List<Muscle> RightLeg { get; set; }
        public List<Muscle> Chest { get; set; }
        public List<Muscle> Back { get; set; }
        public List<Muscle> Stomach { get; set; }

        public Avatar()
        {
            LeftArm = new List<Muscle>
            {
                new Muscle{Name="Biceps"},
                new Muscle{Name="Triceps"},
                new Muscle{Name="Forehand"},
                new Muscle{Name="UpperShoulder"}
            };
        }
    }
}
