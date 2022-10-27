using System;
using System.Collections.Generic;

namespace DMD.PL
{
    public partial class tblCharacterSkillProficiency
    {
        public Guid Id { get; set; }
        public Guid Skill_Id { get; set; }
        public Guid Character_Id { get; set; }

        public virtual tblCharacter Character { get; set; } = null!;
        public virtual tblSkill Skill { get; set; } = null!;
    }
}
