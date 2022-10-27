using System;
using System.Collections.Generic;

namespace DMD.PL
{
    public partial class tblStat
    {
        public tblStat()
        {
            tblAttacks = new HashSet<tblAttack>();
            tblCharacterStats = new HashSet<tblCharacterStat>();
            tblSkills = new HashSet<tblSkill>();
            tblSpells = new HashSet<tblSpell>();
            tblWeapons = new HashSet<tblWeapon>();
        }

        public Guid Id { get; set; }
        public string Name { get; set; } = null!;
        public string Description { get; set; } = null!;

        public virtual ICollection<tblAttack> tblAttacks { get; set; }
        public virtual ICollection<tblCharacterStat> tblCharacterStats { get; set; }
        public virtual ICollection<tblSkill> tblSkills { get; set; }
        public virtual ICollection<tblSpell> tblSpells { get; set; }
        public virtual ICollection<tblWeapon> tblWeapons { get; set; }
    }
}
