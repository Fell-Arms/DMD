using System;
using System.Collections.Generic;

namespace DMD.PL
{
    public partial class tblCharacterLanguage
    {
        public Guid Id { get; set; }
        public Guid Character_Id { get; set; }
        public Guid Language_Id { get; set; }

        public virtual tblCharacter Character { get; set; } = null!;
        public virtual tblLanguage Language { get; set; } = null!;
    }
}
