using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DMD.BL.Models
{
    public class Spell
    {
        public Guid Id { get; set; } // use guid for id
        public Stat Stat { get; set; }
        public List<Guid> SpellDamageType_Ids { get; set; }
        public int Spell_Level { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int Targets { get; set; }
        public bool TargetAllies { get; set; }
        public bool Heal { get; set; }
    }
}
