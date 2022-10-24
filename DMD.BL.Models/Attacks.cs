using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DMD.BL.Models
{
    public class Attacks
    {
        public Guid Id { get; set; } // use guid for id
        public Guid Class_Id { get; set; }
        public Guid Stat_Id { get; set; }
        public Guid WeaponType_Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int Targets { get; set; }
        public int MaxUses { get; set; }
        public bool UseWeapon { get; set; }
        public int Class_Level { get; set; }

    }
}
