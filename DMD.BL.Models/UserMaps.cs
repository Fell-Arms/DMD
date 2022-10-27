using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DMD.BL.Models
{
    public class UserMaps
    {
        public Guid Id { get; set; } // use guid for id
        public Guid User_Id { get; set; }
        public Guid Map_Id { get; set; }
    }
}
