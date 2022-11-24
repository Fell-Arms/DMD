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
        public int CharacterLevelId { get; set; }
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
        public List<CharacterSpellCharge> CharacterSpellCharges { get; set; }
        public List<CharacterClassSpell> CharacterClassSpells { get; set; }
        public List<CharacterClass> CharacterClasses { get; set; }
        public List<CharacterAttack> CharacterAttacks { get; set; }
        public List<CharacterStat> CharacterStats { get; set; }
        public List<CharacterSkill> CharacterSkills { get; set; }
        public List<CharacterLanguage> CharacterLanguages { get; set; }
    }
}
