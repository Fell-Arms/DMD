using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DMD.BL.Models
{
    public class Skill
    {
        public Guid Id { get; set; } // use guid for id
        public Guid Stats_Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
    }
}
