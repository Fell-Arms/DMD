using System;
using System.Collections.Generic;

namespace DMD.PL
{
    public partial class tblCharacterWeapon
    {
        public Guid Id { get; set; }
        public Guid Weapon_Id { get; set; }
        public Guid Character_Id { get; set; }
        public bool Equipped { get; set; }

        public virtual tblCharacter Character { get; set; } = null!;
        public virtual tblWeapon Weapon { get; set; } = null!;
    }
}
