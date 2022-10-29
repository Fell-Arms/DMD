using System;
using System.Collections.Generic;

namespace DMD.PL
{
    public partial class tblSkill
    {
        public tblSkill()
        {
            Characters = new HashSet<tblCharacter>();
        }

        public Guid Id { get; set; }
        public Guid Stats_Id { get; set; }
        public string Name { get; set; } = null!;
        public string Description { get; set; } = null!;

        public virtual tblStat Stats { get; set; } = null!;

        public virtual ICollection<tblCharacter> Characters { get; set; }
    }
}
