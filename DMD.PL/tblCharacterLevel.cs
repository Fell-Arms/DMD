using System;
using System.Collections.Generic;

namespace DMD.PL
{
    public partial class tblCharacterLevel
    {
        public tblCharacterLevel()
        {
            tblCharacters = new HashSet<tblCharacter>();
        }

        public Guid Id { get; set; }
        public int Level { get; set; }
        public int Experience { get; set; }
        public int ProficencyBonus { get; set; }

        public virtual ICollection<tblCharacter> tblCharacters { get; set; }
    }
}
