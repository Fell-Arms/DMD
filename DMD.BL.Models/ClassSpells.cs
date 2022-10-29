using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DMD.BL.Models
{
    public class ClassSpells
    {
        public List<Spell> Spells { get; set; } // use guid for id
        public Guid Class_Id { get; set; } // use guid for id
    }
}