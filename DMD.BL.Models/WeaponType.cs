using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DMD.BL.Models
{
    internal class WeaponType
    {
        public Guid Id { get; set; } // use guid for id
        public string Type { get; set; }
        public string Description { get; set; }
    }
}
