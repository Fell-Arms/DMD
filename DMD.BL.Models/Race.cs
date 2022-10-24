using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DMD.BL.Models
{
    public class Race
    {
        public Guid Id { get; set; } // use guid for id
        public string Name { get; set; } //THIS VALUE IS "RACE" IN DATABASE. CHANGE LATER
        public string Description { get; set; }
    }
}
