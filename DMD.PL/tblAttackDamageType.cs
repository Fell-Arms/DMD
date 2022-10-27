using System;
using System.Collections.Generic;

namespace DMD.PL
{
    public partial class tblAttackDamageType
    {
        public Guid DamageType_Id { get; set; }
        public Guid Attack_Id { get; set; }
        public int? DamageDie { get; set; }
        public int? DamageModifier { get; set; }
        public int? DieCount { get; set; }

        public virtual tblAttack Attack { get; set; } = null!;
        public virtual tblDamageType DamageType { get; set; } = null!;
    }
}
