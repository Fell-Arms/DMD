using System;
using System.Collections.Generic;

namespace DMD.PL
{
    public partial class tblWeaponType
    {
        public tblWeaponType()
        {
            tblAttacks = new HashSet<tblAttack>();
            tblCharacterWeaponTypeProficiencies = new HashSet<tblCharacterWeaponTypeProficiency>();
            tblWeapons = new HashSet<tblWeapon>();
        }

        public Guid Id { get; set; }
        public string Type { get; set; } = null!;
        public string Description { get; set; } = null!;

        public virtual ICollection<tblAttack> tblAttacks { get; set; }
        public virtual ICollection<tblCharacterWeaponTypeProficiency> tblCharacterWeaponTypeProficiencies { get; set; }
        public virtual ICollection<tblWeapon> tblWeapons { get; set; }
    }
}
