using System;
using System.Collections.Generic;

namespace DMD.PL
{
    public partial class tblRace
    {
        public tblRace()
        {
            tblCharacters = new HashSet<tblCharacter>();
        }

        public Guid Id { get; set; }
        public string Name { get; set; } = null!;
        public string Description { get; set; } = null!;

        public virtual ICollection<tblCharacter> tblCharacters { get; set; }
    }
}
