﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DMD.BL.Models
{
    public class Weapon
    {
        public Guid Id { get; set; } // use guid for id
        public Guid WeaponType_Id { get; set; }
        public Guid Stats_Id { get; set; }
        public List<Guid> WeaponDamageType_Ids { get; set; }
        public string Name { get; set; }
        public int Cost { get; set; }
    }
}
