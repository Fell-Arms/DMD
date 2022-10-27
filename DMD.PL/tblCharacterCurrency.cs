using System;
using System.Collections.Generic;

namespace DMD.PL
{
    public partial class tblCharacterCurrency
    {
        public Guid Id { get; set; }
        public Guid Currency_Id { get; set; }
        public Guid Character_Id { get; set; }
        public int Amount { get; set; }

        public virtual tblCharacter Character { get; set; } = null!;
        public virtual tblCurrency Currency { get; set; } = null!;
    }
}
