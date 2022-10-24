using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DMD.BL.Models
{
    public class CharacterLevel
    {
        public Guid Id { get; set; } // use guid for id
        public int Level { get; set; }
        public int Experience { get; set; }
        public int ProficiencyBonus { get; set; }
    }
}
