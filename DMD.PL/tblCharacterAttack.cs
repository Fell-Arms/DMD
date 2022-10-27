using System;
using System.Collections.Generic;

namespace DMD.PL
{
    public partial class tblCharacterAttack
    {
        public Guid Id { get; set; }
        public Guid Character_Id { get; set; }
        public Guid Attack_Id { get; set; }
        public int CurrentUses { get; set; }

        public virtual tblAttack Attack { get; set; } = null!;
        public virtual tblCharacter Character { get; set; } = null!;
    }
}
