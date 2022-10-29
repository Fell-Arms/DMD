using System;
using System.Collections.Generic;

namespace DMD.PL
{
    public partial class tblSpell
    {
        public tblSpell()
        {
            tblClassSpells = new HashSet<tblClassSpell>();
            tblSpellDamageTypes = new HashSet<tblSpellDamageType>();
        }

        public Guid Id { get; set; }
        public Guid Stat_Id { get; set; }
        public int Spell_Level { get; set; }
        public string Name { get; set; } = null!;
        public string Description { get; set; } = null!;
        public int? Targets { get; set; }
        public bool TargetAllies { get; set; }
        public bool Heal { get; set; }

        public virtual tblStat Stat { get; set; } = null!;
        public virtual ICollection<tblClassSpell> tblClassSpells { get; set; }
        public virtual ICollection<tblSpellDamageType> tblSpellDamageTypes { get; set; }
    }
}
