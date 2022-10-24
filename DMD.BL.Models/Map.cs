using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DMD.BL.Models
{
    public class Map
    {
        public Guid Id { get; set; } // use guid for id
        public string Type { get; set; }
        public string ImagePath { get; set; }
    }
}
