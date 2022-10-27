using System;
using System.Collections.Generic;

namespace DMD.PL
{
    public partial class tblAttack
    {
        public tblAttack()
        {
            tblAttackDamageTypes = new HashSet<tblAttackDamageType>();
            tblCharacterAttacks = new HashSet<tblCharacterAttack>();
        }

        public Guid Id { get; set; }
        public Guid Class_Id { get; set; }
        public Guid Stat_Id { get; set; }
        public Guid WeaponType_Id { get; set; }
        public string Name { get; set; } = null!;
        public string Description { get; set; } = null!;
        public int Targets { get; set; }
        public int MaxUses { get; set; }
        public bool UseWeapon { get; set; }
        public int? Class_Level { get; set; }

        public virtual tblClass Class { get; set; } = null!;
        public virtual tblStat Stat { get; set; } = null!;
        public virtual tblWeaponType WeaponType { get; set; } = null!;
        public virtual ICollection<tblAttackDamageType> tblAttackDamageTypes { get; set; }
        public virtual ICollection<tblCharacterAttack> tblCharacterAttacks { get; set; }
    }
}
