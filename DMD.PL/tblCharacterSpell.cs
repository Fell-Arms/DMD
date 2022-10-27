using System;
using System.Collections.Generic;

namespace DMD.PL
{
    public partial class tblCharacterSpell
    {
        public Guid Id { get; set; }
        public Guid Character_Id { get; set; }
        public Guid Spell_Id { get; set; }

        public virtual tblCharacter Character { get; set; } = null!;
        public virtual tblSpell Spell { get; set; } = null!;
    }
}
