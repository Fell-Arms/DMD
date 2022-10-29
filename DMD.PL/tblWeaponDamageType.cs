using System;
using System.Collections.Generic;

namespace DMD.PL
{
    public partial class tblWeaponDamageType
    {
        public Guid Weapon_Id { get; set; }
        public Guid DamageType_id { get; set; }
        public int DamageDie { get; set; }
        public int DamageModifier { get; set; }
        public int DieCount { get; set; }

        public virtual tblDamageType DamageType { get; set; } = null!;
        public virtual tblWeapon Weapon { get; set; } = null!;
    }
}
