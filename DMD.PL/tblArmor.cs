using System;
using System.Collections.Generic;

namespace DMD.PL
{
    public partial class tblArmor
    {
        public tblArmor()
        {
            tblCharacterArmors = new HashSet<tblCharacterArmor>();
        }

        public Guid Id { get; set; }
        public Guid ArmorStyle_Id { get; set; }
        public Guid ArmorType_Id { get; set; }
        public string Name { get; set; } = null!;
        public int ArmorClassBonus { get; set; }
        public int MovementPenalty { get; set; }
        public int Cost { get; set; }

        public virtual tblArmorStyle ArmorStyle { get; set; } = null!;
        public virtual tblArmorType ArmorType { get; set; } = null!;
        public virtual ICollection<tblCharacterArmor> tblCharacterArmors { get; set; }
    }
}
