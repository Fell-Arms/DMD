using System;
using System.Collections.Generic;

namespace DMD.PL
{
    public partial class tblCharacterClassSpell
    {
        public Guid Id { get; set; }
        public Guid Character_Id { get; set; }
        public Guid ClassSpells_Id { get; set; }

        public virtual tblCharacter Character { get; set; } = null!;
        public virtual tblClassSpell ClassSpells { get; set; } = null!;
    }
}
