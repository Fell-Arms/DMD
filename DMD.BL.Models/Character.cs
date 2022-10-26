using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DMD.BL.Models
{
    public class Character
    {
        public List<User> Users { get; set; }
        public List<Character> Characters { get; set; }
        public List<Race> Race { get; set; }
        public List<Class> Classes { get; set; }
        public List<CharacterLevel> CharacterLevel { get; set; }
        public List<CharacterWeapon> CharactersWeapon { get; set; }
        public List<CharacterWeaponTypeProficiency> CharacterWeaponTypeProficiencies { get; set; }
        public List<CharacterAttacks> CharacterAttacks { get; set; }
        public List<CharacterArmor> CharacterArmors { get; set; }
        public List<CharacterSpells> CharacterSpells { get; set; }
        public List<CharacterSpellCharges> CharacterSpellCharges { get; set; }
        public List<CharacterSKillProficiency> CharacterSKillProficiencies { get; set; }
        public List<SpellChargesByLevel> SpellChargesByLevels { get; set; }
        public List<SpellDamageTypes> SpellDamageTypes { get; set; }
        public List<CharacterCurrency> CharacterCurrency { get; set; }
        public List<CharacterLanguages> CharacterLanguages { get; set; }
        public List<Currency> Currency { get; set; }
        
    }
}
