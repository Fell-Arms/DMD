using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DMD.BL.Models
{
    public class Armor
    {
        public Guid Id { get; set; } // use guid for id
        public Guid ArmorStyle_Id { get; set; }
        public Guid ArmorType_Id { get; set; }
        public int ArmorClassBonus { get; set; }
        public int MovementPenalty { get; set; }
        public int Cost { get; set; }
    }
}
