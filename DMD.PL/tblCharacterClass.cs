using System;
using System.Collections.Generic;

namespace DMD.PL
{
    public partial class tblCharacterClass
    {
        public Guid Id { get; set; }
        public Guid Character_Id { get; set; }
        public Guid Class_Id { get; set; }
        public int Class_Level { get; set; }

        public virtual tblCharacter Character { get; set; } = null!;
        public virtual tblClass Class { get; set; } = null!;
    }
}
