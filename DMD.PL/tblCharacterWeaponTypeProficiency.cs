using System;
using System.Collections.Generic;

namespace DMD.PL
{
    public partial class tblCharacterWeaponTypeProficiency
    {
        public Guid Id { get; set; }
        public Guid WeaponType_Id { get; set; }
        public Guid Character_Id { get; set; }

        public virtual tblCharacter Character { get; set; } = null!;
        public virtual tblWeaponType WeaponType { get; set; } = null!;
    }
}
