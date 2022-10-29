using System;
using System.Collections.Generic;

namespace DMD.PL
{
    public partial class tblDamageType
    {
        public tblDamageType()
        {
            tblAttackDamageTypes = new HashSet<tblAttackDamageType>();
            tblSpellDamageTypes = new HashSet<tblSpellDamageType>();
            tblWeaponDamageTypes = new HashSet<tblWeaponDamageType>();
        }

        public Guid Id { get; set; }
        public string Name { get; set; } = null!;
        public string Description { get; set; } = null!;

        public virtual ICollection<tblAttackDamageType> tblAttackDamageTypes { get; set; }
        public virtual ICollection<tblSpellDamageType> tblSpellDamageTypes { get; set; }
        public virtual ICollection<tblWeaponDamageType> tblWeaponDamageTypes { get; set; }
    }
}
