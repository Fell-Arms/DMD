using System;
using System.Collections.Generic;

namespace DMD.PL
{
    public partial class tblSpellDamageType
    {
        public Guid Spell_Id { get; set; }
        public Guid DamageType_Id { get; set; }
        public int DamageDie { get; set; }
        public int DamageModifier { get; set; }
        public int DieCount { get; set; }

        public virtual tblDamageType DamageType { get; set; } = null!;
        public virtual tblSpell Spell { get; set; } = null!;
    }
}
