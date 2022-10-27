using System;
using System.Collections.Generic;

namespace DMD.PL
{
    public partial class tblArmorStyle
    {
        public tblArmorStyle()
        {
            tblArmors = new HashSet<tblArmor>();
        }

        public Guid Id { get; set; }
        public string StyleName { get; set; } = null!;
        public string? Description { get; set; }

        public virtual ICollection<tblArmor> tblArmors { get; set; }
    }
}
