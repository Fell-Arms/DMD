using System;
using System.Collections.Generic;

namespace DMD.PL
{
    public partial class tblSkill
    {
        public tblSkill()
        {
            tblCharacterSkillProficiencies = new HashSet<tblCharacterSkillProficiency>();
        }

        public Guid Id { get; set; }
        public Guid? Stats_Id { get; set; }
        public string? Name { get; set; }
        public string? Description { get; set; }

        public virtual tblStat? Stats { get; set; }
        public virtual ICollection<tblCharacterSkillProficiency> tblCharacterSkillProficiencies { get; set; }
    }
}
