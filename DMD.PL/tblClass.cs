using System;
using System.Collections.Generic;

namespace DMD.PL
{
    public partial class tblClass
    {
        public tblClass()
        {
            tblAttacks = new HashSet<tblAttack>();
            tblCharacterClasses = new HashSet<tblCharacterClass>();
            tblClassSpells = new HashSet<tblClassSpell>();
            tblSpellChargesByLevels = new HashSet<tblSpellChargesByLevel>();
        }

        public Guid Id { get; set; }
        public string Name { get; set; } = null!;
        public string Description { get; set; } = null!;
        public int HPUpDieOnLevel { get; set; }

        public virtual ICollection<tblAttack> tblAttacks { get; set; }
        public virtual ICollection<tblCharacterClass> tblCharacterClasses { get; set; }
        public virtual ICollection<tblClassSpell> tblClassSpells { get; set; }
        public virtual ICollection<tblSpellChargesByLevel> tblSpellChargesByLevels { get; set; }
    }
}
