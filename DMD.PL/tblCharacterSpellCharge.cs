using System;
using System.Collections.Generic;

namespace DMD.PL
{
    public partial class tblCharacterSpellCharge
    {
        public Guid Id { get; set; }
        public Guid Character_Id { get; set; }
        public Guid Spell_Charges_By_Level_Id { get; set; }
        public int ChargesAvaliable { get; set; }

        public virtual tblCharacter Character { get; set; } = null!;
        public virtual tblSpellChargesByLevel Spell_Charges_By_Level { get; set; } = null!;
    }
}
