using System;
using System.Collections.Generic;

namespace DMD.PL
{
    public partial class tblClassSpell
    {
        public Guid Spell_Id { get; set; }
        public Guid? Class_Id { get; set; }

        public virtual tblClass? Class { get; set; }
        public virtual tblSpell Spell { get; set; } = null!;
    }
}
