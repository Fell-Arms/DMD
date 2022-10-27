using System;
using System.Collections.Generic;

namespace DMD.PL
{
    public partial class tblWeapon
    {
        public tblWeapon()
        {
            tblCharacterWeapons = new HashSet<tblCharacterWeapon>();
        }

        public Guid Id { get; set; }
        public Guid WeaponType_Id { get; set; }
        public Guid Stats_Id { get; set; }
        public string Name { get; set; } = null!;
        public int Cost { get; set; }

        public virtual tblStat Stats { get; set; } = null!;
        public virtual tblWeaponType WeaponType { get; set; } = null!;
        public virtual tblWeaponDamageType? tblWeaponDamageType { get; set; }
        public virtual ICollection<tblCharacterWeapon> tblCharacterWeapons { get; set; }
    }
}
