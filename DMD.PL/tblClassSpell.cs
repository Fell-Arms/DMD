using System;
using System.Collections.Generic;

namespace DMD.PL
{
    public partial class tblClassSpell
    {
        public tblClassSpell()
        {
            tblCharacterClassSpells = new HashSet<tblCharacterClassSpell>();
        }

        public Guid Id { get; set; }
        public Guid Spell_Id { get; set; }
        public Guid Class_Id { get; set; }

        public virtual tblClass Class { get; set; } = null!;
        public virtual tblSpell Spell { get; set; } = null!;
        public virtual ICollection<tblCharacterClassSpell> tblCharacterClassSpells { get; set; }
    }
}
