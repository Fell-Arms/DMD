﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DMD.BL.Models
{
    public class CharacterSpellCharge
    {
        public Guid Id { get; set; } // use guid for id
        public Guid Character_Id { get; set; }
        public Guid Spell_Charges_By_Level_Id { get; set; }
        public int ChargesAvailable { get; set; }
    }
}
