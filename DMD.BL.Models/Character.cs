using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DMD.BL.Models
{
    public class Character
    {
        public Guid Id { get; set; }
        public Guid UserId { get; set; }
        public Guid RaceId { get; set; }
        public Guid CharacterLevelId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int MaxHitpoints { get; set; }
        public int CurrentHitpoints { get; set; }
        public string? Background { get; set; }
        public int Experience { get; set; }
        public string? ImagePath { get; set; }
        public List<CharacterArmor> CharacterArmors { get; set; }
        public List<CharacterCurrency> CharacterCurrency { get; set; }
        public List<CharacterWeapon> CharacterWeapons { get; set; }
        public List<CharacterWeaponTypeProficiency> CharacterWeaponTypeProficiencies { get; set; }
        public List<CharacterSpellCharges> CharacterSpellCharges { get; set; }
        public List<CharacterSpells> CharacterSpells { get; set; }
        public List<CharacterClasses> CharacterClasses { get; set; }
        public List<CharacterAttacks> CharacterAttacks { get; set; }
        public List<CharacterStats> CharacterStats { get; set; }
        public List<CharacterSkillProficiency> CharacterSkillProficiencies { get; set; }
        public List<CharacterLanguages> CharacterLanguages { get; set; }
    }
}
