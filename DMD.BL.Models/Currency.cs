using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DMD.BL.Models
{
    public class Currency
    {
        public Guid Id { get; set; } // use guid for id
        public string Name { get; set; }
        public string Value { get; set; }
    }
}
