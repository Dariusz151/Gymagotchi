using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Gymagotchi.Models
{
    public  class Muscle
    {
        public string Name { get; set; }
        public Decimal Size { get; set; }
        public Decimal LoadPerWeek { get; set; }
        public bool Exhausted { get; set; }
        public bool CriticalExhausted { get; set; }
    }
}
