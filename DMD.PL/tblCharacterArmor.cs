using System;
using System.Collections.Generic;

namespace DMD.PL
{
    public partial class tblCharacterArmor
    {
        public Guid Id { get; set; }
        public Guid Armor_Id { get; set; }
        public Guid Character_Id { get; set; }
        public bool Equipped { get; set; }

        public virtual tblArmor Armor { get; set; } = null!;
        public virtual tblCharacter Character { get; set; } = null!;
    }
}
