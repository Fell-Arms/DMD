using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DMD.BL.Models
{
    public class AttackDamageTypes
    {
        public Guid DamageType_Id { get; set; } // use guid for id
        public Guid Attack_Id { get; set; }
        public int DamageDie { get; set; }
        public int DamageModifier { get; set; }
        public int DieCount { get; set; }
    }
}
