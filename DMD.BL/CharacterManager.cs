using DMD.BL.Models;
using DMD.PL;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
namespace DMD.BL
{
    public static class CharacterManager
    {
        /// <summary>
        /// Load all the characters
        /// </summary>
        /// <returns>List of Characters</returns>
        public async static Task<List<Character>> Load()
        {
            try
            {
                List<Character> characters = new List<Character>();
                await Task.Run(() =>
                {
                    using (DMDEntities dc = new DMDEntities())
                    {
                        foreach (tblCharacter c in dc.tblCharacters.ToList())
                        {
                            Character character = new Character
                            {
                                Id = c.Id,
                                UserId = c.User_Id,
                                RaceId = c.Race_Id,
                                CharacterLevelId = c.CharacterLevel_Id,
                                FirstName = c.FirstName,
                                LastName = c.LastName,
                                MaxHitpoints = c.MaxHitpoints,
                                CurrentHitpoints = c.CurrentHitpoints,
                                Background = c.Background,
                                Experience = c.Experience,
                                ImagePath = c.Image
                            };

                            // Create the list of CharacterArmors
                            character.CharacterArmors = new List<CharacterArmor>();
                            foreach (tblCharacterArmor ca in c.tblCharacterArmors.ToList())
                            {
                                CharacterArmor characterArmor = new CharacterArmor()
                                {
                                    Id = ca.Id,
                                    Character_Id = ca.Character_Id,
                                    Armor_Id = ca.Armor_Id,
                                    Equipped = ca.Equipped
                                };
                                //Armor armor = new Armor
                                //{
                                //    Id = ca.Armor_Id,
                                //    ArmorStyle_Id = ca.Armor.ArmorStyle_Id,
                                //    ArmorType_Id = ca.Armor.ArmorType_Id,
                                //    ArmorClassBonus = ca.Armor.ArmorClassBonus,
                                //    MovementPenalty = ca.Armor.MovementPenalty,
                                //    Cost = ca.Armor.Cost
                                //};
                                character.CharacterArmors.Add(characterArmor);
                            }

                            // Create the list of Character Currency
                            character.CharacterCurrency = new List<CharacterCurrency>();
                            foreach (tblCharacterCurrency cc in c.tblCharacterCurrencies.ToList())
                            {
                                CharacterCurrency characterCurrency = new CharacterCurrency
                                {
                                    Id = cc.Id,
                                    Currency_Id = cc.Currency_Id,
                                    Character_Id = cc.Character_Id,
                                    Amount = cc.Amount
                                };
                                character.CharacterCurrency.Add(characterCurrency);
                            }

                            // Create the list of Character Weapons
                            character.CharacterWeapons = new List<CharacterWeapon>();
                            foreach (tblCharacterWeapon cw in c.tblCharacterWeapons.ToList())
                            {
                                CharacterWeapon characterWeapons = new CharacterWeapon
                                {
                                    Id = cw.Id,
                                    Weapon_Id = cw.Weapon_Id,
                                    Character_Id = cw.Character_Id,
                                    Equipped = cw.Equipped
                                };
                                character.CharacterWeapons.Add(characterWeapons);
                            }

                            // Create list of Character's Weapon proficiencies.
                            character.CharacterWeaponTypeProficiencies = new List<CharacterWeaponTypeProficiency>();
                            foreach (tblCharacterWeaponTypeProficiency cwtp in c.tblCharacterWeaponTypeProficiencies.ToList())
                            {
                                CharacterWeaponTypeProficiency characterWeaponTypeProficiency = new CharacterWeaponTypeProficiency
                                {
                                    Id = cwtp.Id,
                                    WeaponType_Id = cwtp.WeaponType_Id,
                                    Character_Id = cwtp.Character_Id,
                                };
                                character.CharacterWeaponTypeProficiencies.Add(characterWeaponTypeProficiency);
                            }

                            //Create the list of Character's Spell charges
                            character.CharacterSpellCharges = new List<CharacterSpellCharge>();
                            foreach (tblCharacterSpellCharge csc in c.tblCharacterSpellCharges.ToList())
                            {
                                CharacterSpellCharge characterSpellCharges = new CharacterSpellCharge
                                {
                                    Id = csc.Id,
                                    Spell_Charges_By_Level_Id = csc.Spell_Charges_By_Level_Id,
                                    Character_Id = csc.Character_Id,
                                    ChargesAvailable = csc.ChargesAvaliable
                                };
                                character.CharacterSpellCharges.Add(characterSpellCharges);
                            }

                            // Create the list of Character's spells
                            character.CharacterClassSpells = new List<CharacterClassSpell>();
                            foreach (tblCharacterClassSpell ccs in c.tblCharacterClassSpells.ToList())
                            {
                                CharacterClassSpell characterClassSpell = new CharacterClassSpell
                                {
                                    Id = ccs.Id,
                                    Character_Id = ccs.Character_Id,
                                    ClassSpell_Id = ccs.ClassSpells_Id
                                };
                                character.CharacterClassSpells.Add(characterClassSpell);
                            }

                            //  Create the list of Character's classes
                            character.CharacterClasses = new List<CharacterClass>();
                            foreach (tblCharacterClass cc in c.tblCharacterClasses.ToList())
                            {
                                CharacterClass characterClass = new CharacterClass
                                {
                                    Id = cc.Id,
                                    Class_Id = cc.Class_Id,
                                    Character_Id = cc.Character_Id,
                                    Class_Level = cc.Class_Level
                                };
                                character.CharacterClasses.Add(characterClass);
                            }

                            // Create the list of Character's attacks
                            character.CharacterAttacks = new List<CharacterAttack>();
                            foreach (tblCharacterAttack ca in c.tblCharacterAttacks.ToList())
                            {
                                CharacterAttack characterAttack = new CharacterAttack
                                {
                                    Id = ca.Id,
                                    Attack_Id = ca.Attack_Id,
                                    Character_Id = ca.Character_Id,
                                    CurrentUses = ca.CurrentUses,
                                };
                                character.CharacterAttacks.Add(characterAttack);
                            }

                            // Create the list of Character's Stats
                            character.CharacterStats = new List<CharacterStat>();
                            foreach (tblCharacterStat cs in c.tblCharacterStats.ToList())
                            {
                                CharacterStat characterStat = new CharacterStat
                                {
                                    Id = cs.Id,
                                    Character_Id = cs.Character_Id,
                                    Stat_Id = cs.Stats_Id,
                                    Value = cs.Value
                                };
                                character.CharacterStats.Add(characterStat);
                            }

                            // Create the list of Character's Proficient Skills
                            character.CharacterSkills = new List<CharacterSkill>();
                            foreach (tblCharacterSkillProficiency csp in c.tblCharacterSkillProficiencies.ToList())
                            {
                                CharacterSkill characterSkill = new CharacterSkill
                                {
                                    Skill_Id = csp.Skill_Id,
                                    Character_Id = csp.Character_Id,
                                    IsProficient = true
                                };

                                character.CharacterSkills.Add(characterSkill);
                            } // Create the list of Character's regular skills
                            foreach (tblSkill s in dc.tblSkills.ToList())
                            {
                                CharacterSkill characterSkill = new CharacterSkill
                                {
                                    Skill_Id = s.Id,
                                    Character_Id = c.Id,
                                    IsProficient = false
                                };

                                bool skillExists = false;

                                foreach (CharacterSkill charSkill in character.CharacterSkills)
                                {
                                    if (charSkill.Skill_Id == characterSkill.Skill_Id)
                                    {
                                        skillExists = true;
                                    }
                                }

                                if (!skillExists)
                                {
                                    character.CharacterSkills.Add(characterSkill);
                                }
                            }

                            //Create the list of Character Languages
                            character.CharacterLanguages = new List<CharacterLanguage>();
                            foreach (tblCharacterLanguage cl in c.tblCharacterLanguages.ToList())
                            {
                                CharacterLanguage characterLanguage = new CharacterLanguage
                                {
                                    Id = cl.Id,
                                    Language_Id = cl.Language_Id,
                                    Character_Id = cl.Character_Id,
                                };
                            }

                            characters.Add(character);
                        }
                    }  //AWAIT ENDS HERE
                });
                return characters;
            }
            catch (Exception)
            {
                throw;
            }
        }

        /// <summary>
        /// Load all of a User's characters.
        /// </summary>
        /// <param name="userid"></param>
        /// <returns>Character List</returns>
        public async static Task<List<Character>> Load(Guid userid)
        {
            try
            {
                List<Character> characters = new List<Character>();
                await Task.Run(() =>
                {
                    using (DMDEntities dc = new DMDEntities())
                    {
                        foreach (tblCharacter c in dc.tblCharacters.ToList().Where(a => a.User_Id == userid))
                        {
                            Character character = new Character
                            {
                                Id = c.Id,
                                UserId = c.User_Id,
                                RaceId = c.Race_Id,
                                CharacterLevelId = c.CharacterLevel_Id,
                                FirstName = c.FirstName,
                                LastName = c.LastName,
                                MaxHitpoints = c.MaxHitpoints,
                                CurrentHitpoints = c.CurrentHitpoints,
                                Background = c.Background,
                                Experience = c.Experience,
                                ImagePath = c.Image
                            };

                            // Create the list of CharacterArmors
                            character.CharacterArmors = new();
                            foreach (tblCharacterArmor ca in c.tblCharacterArmors.ToList())
                            {
                                CharacterArmor characterArmor = new CharacterArmor()
                                {
                                    Id = ca.Id,
                                    Character_Id = ca.Character_Id,
                                    Armor_Id = ca.Armor_Id,
                                    Equipped = ca.Equipped
                                };
                                //Armor armor = new Armor
                                //{
                                //    Id = ca.Armor_Id,
                                //    ArmorStyle_Id = ca.Armor.ArmorStyle_Id,
                                //    ArmorType_Id = ca.Armor.ArmorType_Id,
                                //    ArmorClassBonus = ca.Armor.ArmorClassBonus,
                                //    MovementPenalty = ca.Armor.MovementPenalty,
                                //    Cost = ca.Armor.Cost
                                //};
                                character.CharacterArmors.Add(characterArmor);
                            }

                            // Create the list of Character Currency
                            character.CharacterCurrency = new List<CharacterCurrency>();
                            foreach (tblCharacterCurrency cc in c.tblCharacterCurrencies.ToList())
                            {
                                CharacterCurrency characterCurrency = new CharacterCurrency
                                {
                                    Id = cc.Id,
                                    Currency_Id = cc.Currency_Id,
                                    Character_Id = cc.Character_Id,
                                    Amount = cc.Amount
                                };
                                character.CharacterCurrency.Add(characterCurrency);
                            }

                            // Create the list of Character Weapons
                            character.CharacterWeapons = new List<CharacterWeapon>();
                            foreach (tblCharacterWeapon cw in c.tblCharacterWeapons.ToList())
                            {
                                CharacterWeapon characterWeapons = new CharacterWeapon
                                {
                                    Id = cw.Id,
                                    Weapon_Id = cw.Weapon_Id,
                                    Character_Id = cw.Character_Id,
                                    Equipped = cw.Equipped
                                };
                                character.CharacterWeapons.Add(characterWeapons);
                            }

                            // Create list of Character's Weapon proficiencies.
                            character.CharacterWeaponTypeProficiencies = new List<CharacterWeaponTypeProficiency>();
                            foreach (tblCharacterWeaponTypeProficiency cwtp in c.tblCharacterWeaponTypeProficiencies.ToList())
                            {
                                CharacterWeaponTypeProficiency characterWeaponTypeProficiency = new CharacterWeaponTypeProficiency
                                {
                                    Id = cwtp.Id,
                                    WeaponType_Id = cwtp.WeaponType_Id,
                                    Character_Id = cwtp.Character_Id,
                                };
                                character.CharacterWeaponTypeProficiencies.Add(characterWeaponTypeProficiency);
                            }

                            //Create the list of Character's Spell charges
                            character.CharacterSpellCharges = new List<CharacterSpellCharge>();
                            foreach (tblCharacterSpellCharge csc in c.tblCharacterSpellCharges.ToList())
                            {
                                CharacterSpellCharge characterSpellCharges = new CharacterSpellCharge
                                {
                                    Id = csc.Id,
                                    Spell_Charges_By_Level_Id = csc.Spell_Charges_By_Level_Id,
                                    Character_Id = csc.Character_Id,
                                    ChargesAvailable = csc.ChargesAvaliable
                                };
                                character.CharacterSpellCharges.Add(characterSpellCharges);
                            }

                            // Create the list of Character's spells
                            character.CharacterClassSpells = new List<CharacterClassSpell>();
                            foreach (tblCharacterClassSpell ccs in c.tblCharacterClassSpells.ToList())
                            {
                                CharacterClassSpell characterClassSpell = new CharacterClassSpell
                                {
                                    Id = ccs.Id,
                                    Character_Id = ccs.Character_Id,
                                    ClassSpell_Id = ccs.ClassSpells_Id
                                };
                                character.CharacterClassSpells.Add(characterClassSpell);
                            }

                            //  Create the list of Character's classes
                            character.CharacterClasses = new List<CharacterClass>();
                            foreach (tblCharacterClass cc in c.tblCharacterClasses.ToList())
                            {
                                CharacterClass characterClass = new CharacterClass
                                {
                                    Id = cc.Id,
                                    Class_Id = cc.Class_Id,
                                    Character_Id = cc.Character_Id,
                                    Class_Level = cc.Class_Level
                                };
                                character.CharacterClasses.Add(characterClass);
                            }

                            // Create the list of Character's attacks
                            character.CharacterAttacks = new List<CharacterAttack>();
                            foreach (tblCharacterAttack ca in c.tblCharacterAttacks.ToList())
                            {
                                CharacterAttack characterAttack = new CharacterAttack
                                {
                                    Id = ca.Id,
                                    Attack_Id = ca.Attack_Id,
                                    Character_Id = ca.Character_Id,
                                    CurrentUses = ca.CurrentUses,
                                };
                                character.CharacterAttacks.Add(characterAttack);
                            }

                            // Create the list of Character's Stats
                            character.CharacterStats = new List<CharacterStat>();
                            foreach (tblCharacterStat cs in c.tblCharacterStats.ToList())
                            {
                                CharacterStat characterStat = new CharacterStat
                                {
                                    Id = cs.Id,
                                    Character_Id = cs.Character_Id,
                                    Stat_Id = cs.Stats_Id,
                                    Value = cs.Value
                                };
                                character.CharacterStats.Add(characterStat);
                            }

                            // Create the list of Character's Proficient Skills
                            character.CharacterSkills = new List<CharacterSkill>();
                            foreach (tblCharacterSkillProficiency csp in c.tblCharacterSkillProficiencies.ToList())
                            {
                                CharacterSkill characterSkill = new CharacterSkill
                                {
                                    Skill_Id = csp.Skill_Id,
                                    Character_Id = csp.Character_Id,
                                    IsProficient = true
                                };

                                character.CharacterSkills.Add(characterSkill);
                            } // Create the list of Character's regular skills
                            foreach (tblSkill s in dc.tblSkills.ToList())
                            {
                                CharacterSkill characterSkill = new CharacterSkill
                                {
                                    Skill_Id = s.Id,
                                    Character_Id = c.Id,
                                    IsProficient = false
                                };

                                bool skillExists = false;

                                foreach (CharacterSkill charSkill in character.CharacterSkills)
                                {
                                    if (charSkill.Skill_Id == characterSkill.Skill_Id)
                                    {
                                        skillExists = true;
                                    }
                                }

                                if (!skillExists)
                                {
                                    character.CharacterSkills.Add(characterSkill);
                                }
                                else
                                {
                                    characterSkill = null;
                                }
                            }

                            //Create the list of Character Languages
                            character.CharacterLanguages = new List<CharacterLanguage>();
                            foreach (tblCharacterLanguage cl in c.tblCharacterLanguages.ToList())
                            {
                                CharacterLanguage characterLanguage = new CharacterLanguage
                                {
                                    Id = cl.Id,
                                    Language_Id = cl.Language_Id,
                                    Character_Id = cl.Character_Id,
                                };
                            }

                            characters.Add(character);
                        }
                    }
                });
                return characters;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public async static Task<Character> LoadById(Guid id)
        {
            try
            {
                Character character = new();
                await Task.Run(() =>
                {
                    using (DMDEntities dc = new DMDEntities())
                    {
                        tblCharacter tblCharacter = dc.tblCharacters.Where(c => c.Id == id).FirstOrDefault();
                        if (tblCharacter != null)
                        {
                            // Fill table row values into object

                            character.Id = tblCharacter.Id;
                            character.UserId = tblCharacter.User_Id;
                            character.RaceId = tblCharacter.Race_Id;
                            character.CharacterLevelId = tblCharacter.CharacterLevel_Id;
                            character.FirstName = tblCharacter.FirstName;
                            character.LastName = tblCharacter.LastName;
                            character.MaxHitpoints = tblCharacter.MaxHitpoints;
                            character.CurrentHitpoints = tblCharacter.CurrentHitpoints;
                            character.Background = tblCharacter.Background;
                            character.Experience = tblCharacter.Experience;
                            character.ImagePath = tblCharacter.Image;

                            character.CharacterArmors = new();
                            foreach (tblCharacterArmor ca in tblCharacter.tblCharacterArmors.ToList())
                            {
                                CharacterArmor characterArmor = new CharacterArmor()
                                {
                                    Id = ca.Id,
                                    Character_Id = ca.Character_Id,
                                    Armor_Id = ca.Armor_Id,
                                    Equipped = ca.Equipped
                                };
                                character.CharacterArmors.Add(characterArmor);
                            }

                            character.CharacterCurrency = new();
                            foreach (tblCharacterCurrency cc in tblCharacter.tblCharacterCurrencies.ToList())
                            {
                                CharacterCurrency characterCurrency = new()
                                {
                                    Id = cc.Id,
                                    Character_Id = cc.Character_Id,
                                    Currency_Id = cc.Currency_Id,
                                    Amount = cc.Amount,
                                };
                                character.CharacterCurrency.Add(characterCurrency);
                            }

                            character.CharacterWeapons = new();
                            foreach (tblCharacterWeapon cw in tblCharacter.tblCharacterWeapons.ToList())
                            {
                                CharacterWeapon characterWeapon = new()
                                {
                                    Id = cw.Id,
                                    Weapon_Id = cw.Weapon_Id,
                                    Character_Id = cw.Character_Id,
                                    Equipped = cw.Equipped
                                };
                                character.CharacterWeapons.Add(characterWeapon);
                            }

                            character.CharacterWeaponTypeProficiencies = new();
                            foreach (tblCharacterWeaponTypeProficiency cwtp in tblCharacter.tblCharacterWeaponTypeProficiencies.ToList())
                            {
                                CharacterWeaponTypeProficiency weaponTypeProficiency = new()
                                {
                                    Id = cwtp.Id,
                                    WeaponType_Id = cwtp.WeaponType_Id,
                                    Character_Id = cwtp.Character_Id,
                                };
                                character.CharacterWeaponTypeProficiencies.Add(weaponTypeProficiency);
                            }

                            character.CharacterSpellCharges = new();
                            foreach (tblCharacterSpellCharge tcsc in tblCharacter.tblCharacterSpellCharges.ToList())
                            {
                                CharacterSpellCharge csc = new()
                                {
                                    Id = tcsc.Id,
                                    Character_Id = tcsc.Character_Id,
                                    Spell_Charges_By_Level_Id = tcsc.Spell_Charges_By_Level_Id,
                                    ChargesAvailable = tcsc.ChargesAvaliable
                                };
                                character.CharacterSpellCharges.Add(csc);
                            }

                            character.CharacterClassSpells = new();
                            foreach (tblCharacterClassSpell tccs in tblCharacter.tblCharacterClassSpells.ToList())
                            {
                                CharacterClassSpell ccs = new()
                                {
                                    Id = tccs.Id,
                                    Character_Id = tccs.Character_Id,
                                    ClassSpell_Id = tccs.ClassSpells_Id
                                };
                                character.CharacterClassSpells.Add(ccs);
                            }

                            character.CharacterClasses = new();
                            foreach (tblCharacterClass tcc in tblCharacter.tblCharacterClasses.ToList())
                            {
                                CharacterClass cc = new()
                                {
                                    Id = tcc.Id,
                                    Character_Id = tcc.Character_Id,
                                    Class_Id = tcc.Class_Id,
                                    Class_Level = tcc.Class_Level
                                };
                                character.CharacterClasses.Add(cc);
                            }

                            character.CharacterAttacks = new();
                            foreach (tblCharacterAttack tca in tblCharacter.tblCharacterAttacks.ToList())
                            {
                                CharacterAttack ca = new()
                                {
                                    Id = tca.Id,
                                    Character_Id = tca.Character_Id,
                                    Attack_Id = tca.Attack_Id,
                                    CurrentUses = tca.CurrentUses
                                };
                                character.CharacterAttacks.Add(ca);
                            }

                            character.CharacterStats = new();
                            foreach (tblCharacterStat tcs in tblCharacter.tblCharacterStats.ToList())
                            {
                                CharacterStat characterStat = new()
                                {
                                    Id = tcs.Id,
                                    Character_Id = tcs.Character_Id,
                                    Stat_Id = tcs.Stats_Id,
                                    Value = tcs.Value
                                };
                                character.CharacterStats.Add(characterStat);
                            }

                            // Create the list of Character's Proficient Skills
                            character.CharacterSkills = new();
                            foreach (tblCharacterSkillProficiency csp in tblCharacter.tblCharacterSkillProficiencies.ToList())
                            {
                                CharacterSkill characterSkill = new CharacterSkill
                                {
                                    Skill_Id = csp.Skill_Id,
                                    Character_Id = csp.Character_Id,
                                    IsProficient = true
                                };

                                character.CharacterSkills.Add(characterSkill);
                            } // Create the list of Character's regular skills
                            foreach (tblSkill s in dc.tblSkills.ToList())
                            {
                                CharacterSkill characterSkill = new CharacterSkill
                                {
                                    Skill_Id = s.Id,
                                    Character_Id = character.Id,
                                    IsProficient = false
                                };

                                bool skillExists = false;

                                foreach (CharacterSkill charSkill in character.CharacterSkills)
                                {
                                    if (charSkill.Skill_Id == characterSkill.Skill_Id)
                                    {
                                        skillExists = true;
                                    }
                                }

                                if (!skillExists)
                                {
                                    character.CharacterSkills.Add(characterSkill);
                                }
                            }

                            character.CharacterLanguages = new();
                            foreach (tblCharacterLanguage tcl in tblCharacter.tblCharacterLanguages.ToList())
                            {
                                CharacterLanguage characterLanguage = new()
                                {
                                    Id = tcl.Id,
                                    Character_Id = tcl.Character_Id,
                                    Language_Id = tcl.Language_Id,
                                };
                                character.CharacterLanguages.Add(characterLanguage);
                            }

                            return character;
                        }
                        else
                        {
                            throw new Exception("Row not found.");
                        }
                    }
                });
                return character;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public async static Task<int> Insert(Character character, bool rollback = false)
        {
            try
            {
                int results = 0;
                await Task.Run(() =>
                {
                    using (DMDEntities dc = new DMDEntities())
                    {
                        IDbContextTransaction transaction = dc.Database.BeginTransaction();
                        tblCharacter newrow = new tblCharacter();
                        newrow.Id = Guid.NewGuid();
                        newrow.User_Id = character.UserId;
                        newrow.Race_Id = character.RaceId;
                        newrow.CharacterLevel_Id = character.CharacterLevelId;
                        newrow.FirstName = character.FirstName;
                        newrow.LastName = character.LastName;
                        newrow.MaxHitpoints = character.MaxHitpoints;
                        newrow.CurrentHitpoints = character.CurrentHitpoints;
                        newrow.Background = character.Background;
                        newrow.Experience = character.Experience;
                        newrow.Image = character.ImagePath;

                        character.Id = newrow.Id;
                        dc.tblCharacters.Add(newrow);

                        if (character.CharacterCurrency != null && character.CharacterCurrency.Any())
                        {
                            foreach (CharacterCurrency characterCurrency in character.CharacterCurrency)
                            {
                                tblCharacterCurrency? tblCharacterCurrency = dc.tblCharacterCurrencies.Where(cc => cc.Currency_Id == characterCurrency.Currency_Id && cc.Character_Id == characterCurrency.Character_Id).FirstOrDefault();
                                if (tblCharacterCurrency != null)
                                {
                                    throw new Exception("No duplicate currency!!");
                                }
                                else
                                {
                                    tblCharacterCurrency = new tblCharacterCurrency();
                                    tblCharacterCurrency.Id = Guid.NewGuid();
                                    tblCharacterCurrency.Character_Id = characterCurrency.Character_Id;
                                    tblCharacterCurrency.Currency_Id = characterCurrency.Currency_Id;
                                    tblCharacterCurrency.Amount = characterCurrency.Amount;

                                    characterCurrency.Id = tblCharacterCurrency.Id;
                                    dc.tblCharacterCurrencies.Add(tblCharacterCurrency);
                                }
                            }
                        }


                        if (character.CharacterArmors != null && character.CharacterArmors.Any())
                        {
                            foreach (CharacterArmor characterArmor in character.CharacterArmors)
                            {
                                tblCharacterArmor? tblCharacterArmor = dc.tblCharacterArmors.FirstOrDefault(ca => ca.Armor_Id == characterArmor.Armor_Id && ca.Character_Id == characterArmor.Character_Id);
                                if (tblCharacterArmor != null)
                                {
                                    throw new Exception("No duplicate armor!!");
                                }
                                else
                                {
                                    tblCharacterArmor = new tblCharacterArmor();
                                    tblCharacterArmor.Id = Guid.NewGuid();
                                    tblCharacterArmor.Armor_Id = characterArmor.Armor_Id;
                                    tblCharacterArmor.Character_Id = characterArmor.Character_Id;
                                    tblCharacterArmor.Equipped = characterArmor.Equipped;

                                    characterArmor.Id = tblCharacterArmor.Id;
                                    dc.tblCharacterArmors.Add(tblCharacterArmor);
                                }
                            }
                        }

                        if (character.CharacterWeapons != null && character.CharacterWeapons.Any())
                        {
                            foreach (CharacterWeapon characterWeapons in character.CharacterWeapons)
                            {
                                tblCharacterWeapon? tblCharacterWeapon = dc.tblCharacterWeapons.FirstOrDefault(cw => cw.Weapon_Id == characterWeapons.Weapon_Id && cw.Character_Id == characterWeapons.Character_Id);
                                if (tblCharacterWeapon != null)
                                {
                                    throw new Exception("No duplicate weapons!!");
                                }
                                else
                                {
                                    tblCharacterWeapon = new tblCharacterWeapon();
                                    tblCharacterWeapon.Id = Guid.NewGuid();
                                    tblCharacterWeapon.Weapon_Id = characterWeapons.Weapon_Id;
                                    tblCharacterWeapon.Character_Id = characterWeapons.Character_Id;
                                    tblCharacterWeapon.Equipped = characterWeapons.Equipped;

                                    characterWeapons.Id = tblCharacterWeapon.Id;
                                    dc.tblCharacterWeapons.Add(tblCharacterWeapon);
                                }
                            }
                        }



                        if (character.CharacterWeaponTypeProficiencies != null && character.CharacterWeaponTypeProficiencies.Any())
                        {
                            foreach (CharacterWeaponTypeProficiency characterWeaponTypeProficiency in character.CharacterWeaponTypeProficiencies)
                            {
                                tblCharacterWeaponTypeProficiency? tblCharacterWeaponTypeProficiency = dc.tblCharacterWeaponTypeProficiencies.FirstOrDefault(wtp => wtp.WeaponType_Id == characterWeaponTypeProficiency.WeaponType_Id && wtp.Character_Id == characterWeaponTypeProficiency.Character_Id);
                                if (tblCharacterWeaponTypeProficiency != null)
                                {
                                    throw new Exception("No duplicate proficiencies!!");
                                }
                                else
                                {
                                    tblCharacterWeaponTypeProficiency = new tblCharacterWeaponTypeProficiency();
                                    tblCharacterWeaponTypeProficiency.Id = Guid.NewGuid();
                                    tblCharacterWeaponTypeProficiency.WeaponType_Id = tblCharacterWeaponTypeProficiency.WeaponType_Id;
                                    tblCharacterWeaponTypeProficiency.Character_Id = tblCharacterWeaponTypeProficiency.Character_Id;

                                    characterWeaponTypeProficiency.Id = tblCharacterWeaponTypeProficiency.Id;
                                    dc.tblCharacterWeaponTypeProficiencies.Add(tblCharacterWeaponTypeProficiency);
                                }
                            }
                        }

                        if (character.CharacterSpellCharges != null && character.CharacterSpellCharges.Any())
                        {
                            foreach (CharacterSpellCharge characterSpellCharges in character.CharacterSpellCharges)
                            {
                                tblCharacterSpellCharge? tblCharacterSpellCharge = dc.tblCharacterSpellCharges.FirstOrDefault(sc => sc.Spell_Charges_By_Level_Id == characterSpellCharges.Spell_Charges_By_Level_Id && sc.Character_Id == characterSpellCharges.Character_Id);
                                if (tblCharacterSpellCharge != null)
                                {
                                    throw new Exception("No duplicate spell charges!!");
                                }
                                else
                                {
                                    tblCharacterSpellCharge = new tblCharacterSpellCharge();
                                    tblCharacterSpellCharge.Id = Guid.NewGuid();
                                    tblCharacterSpellCharge.Spell_Charges_By_Level_Id = characterSpellCharges.Spell_Charges_By_Level_Id;
                                    tblCharacterSpellCharge.Character_Id = characterSpellCharges.Character_Id;

                                    characterSpellCharges.Id = tblCharacterSpellCharge.Id;
                                    dc.tblCharacterSpellCharges.Add(tblCharacterSpellCharge);
                                }
                            }
                        }





                        if (character.CharacterClassSpells != null && character.CharacterClassSpells.Any())
                        {
                            foreach (CharacterClassSpell characterClassSpell in character.CharacterClassSpells)
                            {
                                tblCharacterClassSpell? tblCharacterClassSpell = dc.tblCharacterClassSpells.FirstOrDefault(ccs => ccs.ClassSpells_Id == characterClassSpell.ClassSpell_Id && ccs.Character_Id == characterClassSpell.Character_Id);
                                if (tblCharacterClassSpell != null)
                                {
                                    throw new Exception("No duplicate spells!!");
                                }
                                else
                                {
                                    tblCharacterClassSpell = new tblCharacterClassSpell();
                                    tblCharacterClassSpell.Id = Guid.NewGuid();
                                    tblCharacterClassSpell.Character_Id = characterClassSpell.Character_Id;
                                    tblCharacterClassSpell.ClassSpells_Id = characterClassSpell.ClassSpell_Id;

                                    characterClassSpell.Id = tblCharacterClassSpell.Id;
                                    dc.tblCharacterClassSpells.Add(tblCharacterClassSpell);
                                }
                            }
                        }



                        if (character.CharacterClasses != null && character.CharacterClasses.Any())
                        {
                            foreach (CharacterClass characterClass in character.CharacterClasses)
                            {
                                tblCharacterClass? tblCharacterClass = dc.tblCharacterClasses.FirstOrDefault(cca => cca.Class_Id == characterClass.Class_Id && cca.Character_Id == characterClass.Character_Id);
                                if (tblCharacterClass != null)
                                {
                                    throw new Exception("No duplicate spells!!");
                                }
                                else
                                {
                                    tblCharacterClass = new tblCharacterClass();
                                    tblCharacterClass.Id = Guid.NewGuid();
                                    tblCharacterClass.Character_Id = tblCharacterClass.Class_Id;
                                    tblCharacterClass.Class_Level = tblCharacterClass.Class_Level;
                                    tblCharacterClass.Class_Id = tblCharacterClass.Class_Id;

                                    characterClass.Id = tblCharacterClass.Id;
                                    dc.tblCharacterClasses.Add(tblCharacterClass);
                                }
                            }
                        }


                        if (character.CharacterAttacks != null && character.CharacterAttacks.Any())
                        {
                            foreach (CharacterAttack characterAttack in character.CharacterAttacks)
                            {
                                tblCharacterAttack? tblCharacterAttack = dc.tblCharacterAttacks.FirstOrDefault(caa => caa.Attack_Id == characterAttack.Attack_Id && caa.Character_Id == characterAttack.Character_Id);
                                if (tblCharacterAttack != null)
                                {
                                    throw new Exception("No duplicate attacks!!");
                                }
                                else
                                {
                                    tblCharacterAttack = new tblCharacterAttack();
                                    tblCharacterAttack.Id = Guid.NewGuid();
                                    tblCharacterAttack.Character_Id = characterAttack.Character_Id;
                                    tblCharacterAttack.Attack_Id = characterAttack.Attack_Id;
                                    tblCharacterAttack.CurrentUses = characterAttack.CurrentUses;

                                    characterAttack.Id = tblCharacterAttack.Id;
                                    dc.tblCharacterAttacks.Add(tblCharacterAttack);
                                }
                            }
                        }


                        if (character.CharacterStats != null && character.CharacterStats.Any())
                        {
                            foreach (CharacterStat CharacterStat in character.CharacterStats)
                            {
                                tblCharacterStat? tblCharacterStat = dc.tblCharacterStats.FirstOrDefault(cst => cst.Stats_Id == cst.Stats_Id && cst.Character_Id == CharacterStat.Character_Id);
                                if (tblCharacterStat != null)
                                {
                                    throw new Exception("No duplicate stats!!");
                                }
                                else
                                {
                                    tblCharacterStat = new tblCharacterStat();
                                    tblCharacterStat.Id = Guid.NewGuid();
                                    tblCharacterStat.Character_Id = CharacterStat.Character_Id;
                                    tblCharacterStat.Stats_Id = CharacterStat.Stat_Id;
                                    tblCharacterStat.Value = CharacterStat.Value;

                                    CharacterStat.Id = tblCharacterStat.Id;
                                    dc.tblCharacterStats.Add(tblCharacterStat);
                                }
                            }
                        }

                        if (character.CharacterSkills != null && character.CharacterSkills.Any())
                        {
                            foreach (CharacterSkill characterSkill in character.CharacterSkills)
                            {
                                tblCharacterSkillProficiency? tblCharacterSkillProficiency = dc.tblCharacterSkillProficiencies.FirstOrDefault(csp => csp.Skill_Id == characterSkill.Skill_Id && csp.Character_Id == characterSkill.Character_Id);
                                if (tblCharacterSkillProficiency != null)
                                {
                                    throw new Exception("No duplicate skill proficiency!!");
                                }

                                if (characterSkill.IsProficient)
                                {
                                    tblCharacterSkillProficiency = new tblCharacterSkillProficiency();
                                    tblCharacterSkillProficiency.Character_Id = characterSkill.Character_Id;
                                    tblCharacterSkillProficiency.Skill_Id = characterSkill.Skill_Id;
                                    tblCharacterSkillProficiency.ValidRow = true;

                                    dc.tblCharacterSkillProficiencies.Add(tblCharacterSkillProficiency);
                                }
                            }
                        }

                        if (character.CharacterLanguages != null && character.CharacterLanguages.Any())
                        {
                            foreach (CharacterLanguage characterLanguage in character.CharacterLanguages)
                            {
                                tblCharacterLanguage? tblCharacterLanguage = dc.tblCharacterLanguages.FirstOrDefault(cl => cl.Language_Id == cl.Language_Id && cl.Character_Id == characterLanguage.Character_Id);
                                if (characterLanguage != null)
                                {
                                    throw new Exception("No duplicate language!!");
                                }
                                else
                                {
                                    tblCharacterLanguage = new tblCharacterLanguage();
                                    tblCharacterLanguage.Id = Guid.NewGuid();
                                    tblCharacterLanguage.Character_Id = characterLanguage.Character_Id;
                                    tblCharacterLanguage.Language_Id = characterLanguage.Language_Id;

                                    characterLanguage.Id = tblCharacterLanguage.Id;
                                    dc.tblCharacterLanguages.Add(tblCharacterLanguage);
                                }
                            }
                        }





                        results = dc.SaveChanges();
                        if (rollback) { transaction.RollbackAsync(); }
                        else { transaction.CommitAsync(); }
                    }
                });
                return results;
            }
            catch (Exception)
            {
                throw;
            }
        }


        /*
        public async static Task<int> Update(Character character, bool rollback = false)
        {
            try
            {
                IDbContextTransaction transaction = null;
                using (DMDEntities dc = new DMDEntities())
                {
                    tblCharacter row = await dc.tblCharacters.FirstOrDefaultAsync(q => q.Id == character.Id);
                    int results = 0;
                    if (row != null)
                    {
                        if (rollback) { transaction = await dc.Database.BeginTransactionAsync().ConfigureAwait(false); }
                        row.Character = character.Text;
                        results = await dc.SaveChangesAsync().ConfigureAwait(false);
                        if (transaction != null) { await transaction.RollbackAsync().ConfigureAwait(false); }
                    }
                    else
                    {
                        throw new Exception("Row was not found.");
                    }
                    return results;
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
        public async static Task<int> Delete(Guid id, bool rollback = false)
        {
            try
            {
                using (DMDEntities dc = new DMDEntities())
                {
                    tblCharacter? row = await dc.tblCharacters.FirstOrDefaultAsync(q => q.Id == id).ConfigureAwait(false);
                    int results = 0;
                    if (row != null)
                    {
                        IDbContextTransaction transaction = await dc.Database.BeginTransactionAsync().ConfigureAwait(false);
                        // Delete the characters from tblCharacterAnswer
                        List<tblCharacterAnswer> characterAnswerRows = new List<tblCharacterAnswer>();
                        characterAnswerRows.AddRange(dc.tblCharacterAnswers.Where(qa => qa.CharacterId == id));
                        if (characterAnswerRows.Any())
                        {
                            foreach (tblCharacterAnswer character in characterAnswerRows)
                            {
                                dc.tblCharacterAnswers.Remove(character);
                            }
                        }
                        // Delete the rows where the character is referenced in tblResponse
                        List<tblResponse> responseRows = new();
                        responseRows.AddRange(dc.tblResponses.Where(r => r.CharacterId == id));
                        if (responseRows.Any())
                        {
                            foreach (tblResponse response in responseRows)
                            {
                                dc.tblResponses.Remove(response);
                            }
                        }
                        // Delete the rows where the character is referenced in tblActivation
                        List<tblUser> activationRows = new();
                        activationRows.AddRange(dc.tblActivations.Where(a => a.CharacterId == id));
                        if (activationRows.Any())
                        {
                            foreach (tblActivation activation in activationRows)
                            {
                                dc.tblActivations.Remove(activation);
                            }
                        }
                        dc.tblCharacters.Remove(row);
                        results = await dc.SaveChangesAsync().ConfigureAwait(false);
                        if (rollback) { await transaction.RollbackAsync().ConfigureAwait(false); }
                        else { await transaction.CommitAsync().ConfigureAwait(false); }
                    }
                    else
                    {
                        throw new Exception("Row not found.");
                    }
                    return results;
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
        */
    }
}