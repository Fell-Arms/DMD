using System;
using System.Collections.Generic;

namespace DMD.PL
{
    public partial class tblStatModifier
    {
        public tblStatModifier()
        {
            tblCharacterStats = new HashSet<tblCharacterStat>();
        }

        public int Value { get; set; }
        public int Modifier { get; set; }

        public virtual ICollection<tblCharacterStat> tblCharacterStats { get; set; }
    }
}
