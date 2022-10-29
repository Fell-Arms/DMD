using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DMD.BL.Models
{
    public class CharacterStat
    {
        public Guid Character_Id { get; set; }
        public Guid Stat_Id { get; set; }
        public int Value { get; set; }
    }
}
