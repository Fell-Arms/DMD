using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DMD.BL.Models
{
    public class CharacterCurrency
    {
        public Guid Id { get; set; } // use guid for id
        public Guid Currency_Id { get; set; }
        public Guid Character_Id { get; set; }
        public int Amount { get; set; }
    }
}
