using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DMD.BL.Models
{
    public class CharacterSkill
    {
        public Guid Character_Id { get; set; }
        public Guid Skill_Id { get; set; }
        public bool IsProficient { get; set; }
    }
}
