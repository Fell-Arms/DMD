using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DMD.BL.Models
{
    public class ArmorType
    {
        public Guid Id { get; set; } // use guid for id
        public string TypeName { get; set; }
        public string Description { get; set; }
    }
}
