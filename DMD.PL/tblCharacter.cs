using System;
using System.Collections.Generic;

namespace DMD.PL
{
    public partial class tblCharacter
    {
        public tblCharacter()
        {
            tblCharacterArmors = new HashSet<tblCharacterArmor>();
            tblCharacterAttacks = new HashSet<tblCharacterAttack>();
            tblCharacterClasses = new HashSet<tblCharacterClass>();
            tblCharacterCurrencies = new HashSet<tblCharacterCurrency>();
            tblCharacterLanguages = new HashSet<tblCharacterLanguage>();
            tblCharacterSkillProficiencies = new HashSet<tblCharacterSkillProficiency>();
            tblCharacterSpellCharges = new HashSet<tblCharacterSpellCharge>();
            tblCharacterSpells = new HashSet<tblCharacterSpell>();
            tblCharacterStats = new HashSet<tblCharacterStat>();
            tblCharacterWeaponTypeProficiencies = new HashSet<tblCharacterWeaponTypeProficiency>();
            tblCharacterWeapons = new HashSet<tblCharacterWeapon>();
        }

        public Guid Id { get; set; }
        public Guid User_Id { get; set; }
        public Guid Race_Id { get; set; }
        public Guid CharacterLevel_Id { get; set; }
        public string FirstName { get; set; } = null!;
        public string LastName { get; set; } = null!;
        public int MaxHitpoints { get; set; }
        public int CurrentHitpoints { get; set; }
        public string? Background { get; set; }
        public int Experience { get; set; }
        public string? Image { get; set; }

        public virtual tblCharacterLevel CharacterLevel { get; set; } = null!;
        public virtual tblRace Race { get; set; } = null!;
        public virtual tblUser User { get; set; } = null!;
        public virtual ICollection<tblCharacterArmor> tblCharacterArmors { get; set; }
        public virtual ICollection<tblCharacterAttack> tblCharacterAttacks { get; set; }
        public virtual ICollection<tblCharacterClass> tblCharacterClasses { get; set; }
        public virtual ICollection<tblCharacterCurrency> tblCharacterCurrencies { get; set; }
        public virtual ICollection<tblCharacterLanguage> tblCharacterLanguages { get; set; }
        public virtual ICollection<tblCharacterSkillProficiency> tblCharacterSkillProficiencies { get; set; }
        public virtual ICollection<tblCharacterSpellCharge> tblCharacterSpellCharges { get; set; }
        public virtual ICollection<tblCharacterSpell> tblCharacterSpells { get; set; }
        public virtual ICollection<tblCharacterStat> tblCharacterStats { get; set; }
        public virtual ICollection<tblCharacterWeaponTypeProficiency> tblCharacterWeaponTypeProficiencies { get; set; }
        public virtual ICollection<tblCharacterWeapon> tblCharacterWeapons { get; set; }
    }
}
