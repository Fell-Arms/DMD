using System;
using System.Collections.Generic;

namespace DMD.PL
{
    public partial class tblCharacterStat
    {
        public Guid Id { get; set; }
        public Guid Character_Id { get; set; }
        public Guid Stats_Id { get; set; }
        public int Value { get; set; }

        public virtual tblCharacter Character { get; set; } = null!;
        public virtual tblStat Stats { get; set; } = null!;
    }
}
