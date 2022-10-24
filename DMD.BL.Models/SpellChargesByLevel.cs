using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DMD.BL.Models
{
    public class SpellChargesByLevel
    {
        public Guid Id { get; set; } // use guid for id
        public Guid Class_Id { get; set; }
        public int Class_Level { get; set; }
        public int SpellChargeLevel { get; set; }
        public int ChargesMax { get; set; }
    }
}
