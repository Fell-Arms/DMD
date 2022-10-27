using System;
using System.Collections.Generic;

namespace DMD.PL
{
    public partial class tblDamageType
    {
        public tblDamageType()
        {
            tblWeaponDamageTypes = new HashSet<tblWeaponDamageType>();
        }

        public Guid Id { get; set; }
        public string Name { get; set; } = null!;
        public string Description { get; set; } = null!;

        public virtual tblAttackDamageType? tblAttackDamageType { get; set; }
        public virtual tblSpellDamageType? tblSpellDamageType { get; set; }
        public virtual ICollection<tblWeaponDamageType> tblWeaponDamageTypes { get; set; }
    }
}
