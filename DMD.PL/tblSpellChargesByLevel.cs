using System;
using System.Collections.Generic;

namespace DMD.PL
{
    public partial class tblSpellChargesByLevel
    {
        public tblSpellChargesByLevel()
        {
            tblCharacterSpellCharges = new HashSet<tblCharacterSpellCharge>();
        }

        public Guid Id { get; set; }
        public Guid Class_Id { get; set; }
        public int Class_Level { get; set; }
        public int Spell_Charge_Level { get; set; }
        public int ChargesMax { get; set; }

        public virtual tblClass Class { get; set; } = null!;
        public virtual ICollection<tblCharacterSpellCharge> tblCharacterSpellCharges { get; set; }
    }
}
