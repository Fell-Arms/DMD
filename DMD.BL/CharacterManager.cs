//using DMD.BL.Models;
//using DMD.PL;
//using Microsoft.EntityFrameworkCore;
//using Microsoft.EntityFrameworkCore.Storage;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Runtime.CompilerServices;
//using System.Text;
//using System.Threading.Tasks;
//namespace DMD.BL
//{
//    public static class CharacterManager
//    {
//        public async static Task<List<Character>> Load()
//        {
//            try
//            {
//                List<Character> characters = new List<Character>();
//                await Task.Run(() =>
//                {
//                    using (DMDEntities dc = new DMDEntities())
//                    {
//                        foreach (tblCharacter c in dc.tblCharacters.ToList())
//                        {
//                            Character character = new Character
//                            {
//                                Id = c.Id,
//                                UserId = c.User_Id,
//                                RaceId = c.Race_Id,
//                                CharacterLevelId = c.CharacterLevel_Id,
//                                FirstName = c.FirstName,
//                                LastName = c.LastName,
//                                MaxHitpoints = c.MaxHitpoints,
//                                CurrentHitpoints = c.CurrentHitpoints,
//                                Background = c.Background,
//                                Experience = c.Experience,
//                                ImagePath = c.Image
//                            };

//                            // Create the list of CharacterArmors
//                            character.CharacterArmors = new List<CharacterArmor>();
//                            foreach (tblCharacterArmor ca in c.tblCharacterArmors.ToList())
//                            {
//                                CharacterArmor characterArmor = new CharacterArmor()
//                                {
//                                    Id = ca.Id,
//                                    Character_Id = ca.Character_Id,
//                                    Armor_Id = ca.Armor_Id,
//                                    Equipped = ca.Equipped
//                                };
//                                //Armor armor = new Armor
//                                //{
//                                //    Id = ca.Armor_Id,
//                                //    ArmorStyle_Id = ca.Armor.ArmorStyle_Id,
//                                //    ArmorType_Id = ca.Armor.ArmorType_Id,
//                                //    ArmorClassBonus = ca.Armor.ArmorClassBonus,
//                                //    MovementPenalty = ca.Armor.MovementPenalty,
//                                //    Cost = ca.Armor.Cost
//                                //};
//                                character.CharacterArmors.Add(characterArmor);
//                            }

//                            // Create the list of Character Currency
//                            character.CharacterCurrency = new List<CharacterCurrency>();
//                            foreach (tblCharacterCurrency cc in c.tblCharacterCurrencies.ToList())
//                            {
//                                CharacterCurrency characterCurrency = new CharacterCurrency
//                                {
//                                    Id = cc.Id,
//                                    Currency_Id = cc.Currency_Id,
//                                    Character_Id = cc.Character_Id,
//                                    Amount = cc.Amount
//                                };
//                                character.CharacterCurrency.Add(characterCurrency);
//                            }

//                            // Create the list of Character Weapons
//                            character.CharacterWeapons = new List<CharacterWeapon>();
//                            foreach (tblCharacterWeapon cw in c.tblCharacterWeapons.ToList())
//                            {
//                                CharacterWeapon characterWeapons = new CharacterWeapon
//                                {
//                                    Id = cw.Id,
//                                    Weapon_Id = cw.Weapon_Id,
//                                    Character_Id = cw.Character_Id,
//                                    Equipped = cw.Equipped
//                                };
//                                character.CharacterWeapons.Add(characterWeapons);
//                            }

//                            // Create list of Character's Weapon proficiencies.
//                            character.CharacterWeaponTypeProficiencies = new List<CharacterWeaponTypeProficiency>();
//                            foreach (tblCharacterWeaponTypeProficiency cwtp in c.tblCharacterWeaponTypeProficiencies.ToList())
//                            {
//                                CharacterWeaponTypeProficiency characterWeaponTypeProficiency = new CharacterWeaponTypeProficiency
//                                {
//                                    Id = cwtp.Id,
//                                    WeaponType_Id = cwtp.WeaponType_Id,
//                                    Character_Id = cwtp.Character_Id,
//                                };
//                                character.CharacterWeaponTypeProficiencies.Add(characterWeaponTypeProficiency);
//                            }

//                            //Create the list of Character's Spell charges
//                            character.CharacterSpellCharges = new List<CharacterSpellCharge>();
//                            foreach (tblCharacterSpellCharge csc in c.tblCharacterSpellCharges.ToList())
//                            {
//                                CharacterSpellCharge characterSpellCharges = new CharacterSpellCharge
//                                {
//                                    Id = csc.Id,
//                                    Spell_Charges_By_Level_Id = csc.Spell_Charges_By_Level_Id,
//                                    Character_Id = csc.Character_Id,
//                                    ChargesAvailable = csc.ChargesAvaliable
//                                };
//                                character.CharacterSpellCharges.Add(characterSpellCharges);
//                            }

//                            // Create the list of Character's spells
//                            character.CharacterSpells = new List<CharacterSpell>();
//                            foreach (tblCharacterSpell cs in c.tblCharacterSpells.ToList())
//                            {
//                                CharacterSpell characterSpells = new CharacterSpell
//                                {
//                                    Id = cs.Id,
//                                    Character_Id = cs.Character_Id,
//                                    Spell_Id = cs.Spell_Id,
//                                };
//                                character.CharacterSpells.Add(characterSpells);
//                            }

//                            //  Create the list of Character's classes
//                            character.CharacterClasses = new List<CharacterClass>();
//                            foreach (tblCharacterClass cc in c.tblCharacterClasses.ToList())
//                            {
//                                CharacterClass characterClass = new CharacterClass
//                                {
//                                    Id = cc.Id,
//                                    Class_Id = cc.Class_Id,
//                                    Character_Id = cc.Character_Id,
//                                    Class_Level = cc.Class_Level
//                                };
//                                character.CharacterClasses.Add(characterClass);
//                            }

//                            // Create the list of Character's attacks
//                            character.CharacterAttacks = new List<CharacterAttack>();
//                            foreach (tblCharacterAttack ca in c.tblCharacterAttacks.ToList())
//                            {
//                                CharacterAttack characterAttack = new CharacterAttack
//                                {
//                                    Id = ca.Id,
//                                    Attack_Id = ca.Attack_Id,
//                                    Character_Id = ca.Character_Id,
//                                    CurrentUses = ca.CurrentUses,
//                                };
//                                character.CharacterAttacks.Add(characterAttack);
//                            }

//                            // Create the list of Character's Stats
//                            character.CharacterStats = new List<CharacterStat>();
//                            foreach (tblCharacterStat cs in c.tblCharacterStats.ToList())
//                            {
//                                CharacterStat characterStat = new CharacterStat
//                                {
//                                    Id = cs.Id,
//                                    Character_Id = cs.Character_Id,
//                                    Stat_Id = cs.Stats_Id,
//                                    Value = cs.Value
//                                };
//                                character.CharacterStats.Add(characterStat);
//                            }

//                            // Create the list of Character's Proficient Skills
//                            character.CharacterSkills = new List<CharacterSkill>();
//                            foreach (tblCharacterSkillProficiency csp in c.tblCharacterSkillProficiencies.ToList())
//                            {
//                                CharacterSkill characterSkill = new CharacterSkill
//                                {
//                                    Id = csp.Id,
//                                    Skill_Id = csp.Skill_Id,
//                                    Character_Id = csp.Character_Id,
//                                    IsProficient = true
//                                };
//                                character.CharacterSkills.Add(characterSkill);
//                            } // Create the list of Character's regular skills
//                            foreach (tblSkill s in dc.tblSkills.ToList())
//                            {
//                                CharacterSkill characterSkill = new CharacterSkill
//                                {
//                                    Id = ,

//                                };
//                            }

//                            characters.Add(character);
//                        }
//                    }
//                });
//                return characters;
//            }
//            catch (Exception)
//            {
//                throw;
//            }
//        }






//        public async static Task<Character> LoadById(Guid id)
//        {
//            try
//            {
//                BL.Models.Character character = new Models.Character();
//                await Task.Run(() =>
//                {
//                    using (DMDEntities dc = new DMDEntities())
//                    {
//                        tblCharacter tblCharacter = dc.tblCharacters.Where(q => q.Id == id).FirstOrDefault();
//                        if (tblCharacter != null)
//                        {
//                            // Fill table row values into object




//                            character.CharacterArmors = new List<CharacterArmor>();
//                            character.CharacterCurrency = new List<CharacterCurrency>();
//                            character.CharacterWeapons = new List<CharacterWeapon>();
//                            character.CharacterWeaponTypeProficiencies = new List<CharacterWeaponTypeProficiency>();
//                            character.CharacterSpellCharges = new List<CharacterSpellCharge>();
//                            character.CharacterSpells = new List<CharacterSpell>();
//                            character.CharacterClasses = new List<CharacterClass>();
//                            character.CharacterAttacks = new List<CharacterAttack>();
//                            character.CharacterStats = new List<CharacterStat>();
//                            character.CharacterSkillProficiencies = new List<CharacterSKillProficiency>();
//                            character.CharacterLanguages = new List<CharacterLanguage>();




//                            character.Activations = new();
//                            try
//                            {
//                                List<tblCharacterAnswer> tblCharacterAnswers = new List<tblCharacterAnswer>();
//                                List<tblActivation> tblActivations = new();
//                                tblCharacterAnswers.AddRange(dc.tblCharacterAnswers.Where(qa => qa.CharacterId == id));
//                                tblActivations.AddRange(dc.tblActivations.Where(a => a.CharacterId == id));
//                                foreach (tblCharacterAnswer qa in tblCharacterAnswers)
//                                {
//                                    Answer answer = new Answer
//                                    {
//                                        Id = qa.AnswerId,
//                                        IsCorrect = qa.IsCorrect,
//                                        Text = qa.Answer.Answer
//                                    };
//                                    character.Answers.Add(answer);
//                                }
//                                foreach (tblActivation a in tblActivations)
//                                {
//                                    Activation activation = new Activation
//                                    {
//                                        Id = a.Id,
//                                        StartDate = a.StartDate,
//                                        EndDate = a.EndDate,
//                                        ActivationCode = a.ActivationCode
//                                    };
//                                    character.Activations.Add(activation);
//                                }
//                            }
//                            catch (Exception)
//                            {
//                                throw;
//                            }
//                        }
//                        else
//                        {
//                            throw new Exception("Row not found.");
//                        }
//                    }
//                });
//                return character;
//            }
//            catch (Exception)
//            {
//                throw;
//            }
//        }
//        public async static Task<Character> Load(string activationCode)
//        {
//            try
//            {
//                Character character = new();
//                await Task.Run(() =>
//                {
//                    using (DMDEntities dc = new())
//                    {
//                        Activation activation = new();
//                        tblActivation? tblActivation = dc.tblActivations.Where(a => a.ActivationCode == activationCode).FirstOrDefault();
//                        if (tblActivation == null) { throw new ArgumentNullException("Activation code not found.", nameof(tblActivation)); }
//                        if (DateTime.Now > tblActivation.EndDate) { throw new Exception("This activation code has already expired."); }
//                        activation.Id = tblActivation.Id;
//                        activation.StartDate = tblActivation.StartDate;
//                        activation.EndDate = tblActivation.EndDate;
//                        activation.ActivationCode = tblActivation.ActivationCode;
//                        tblCharacter? tblCharacter = dc.tblCharacters.Where(q => q.Id == tblActivation.CharacterId).FirstOrDefault();
//                        if (tblCharacter == null) { throw new Exception("Character not found."); }
//                        character.Id = tblCharacter.Id;
//                        character.Text = tblCharacter.Character;
//                        character.Answers = new();
//                        character.Activations = new();
//                        character.Activations.Add(activation);
//                        List<tblCharacterAnswer> tblCharacterAnswers = new();
//                        tblCharacterAnswers.AddRange(dc.tblCharacterAnswers.Where(qa => qa.CharacterId == tblCharacter.Id));
//                        foreach (tblCharacterAnswer qa in tblCharacterAnswers)
//                        {
//                            Answer answer = new Answer
//                            {
//                                Id = qa.AnswerId,
//                                IsCorrect = qa.IsCorrect,
//                                Text = qa.Answer.Answer
//                            };
//                            character.Answers.Add(answer);
//                        }
//                    }
//                });
//                return character;
//            }
//            catch (Exception)
//            {
//                throw;
//            }
//        }

//        public async static Task<int> Insert(Character character, bool rollback = false)
//        {
//            try
//            {
//                int results = 0;
//                await Task.Run(() =>
//                {
//                    using (DMDEntities dc = new DMDEntities())
//                    {
//                        IDbContextTransaction transaction = dc.Database.BeginTransaction();
//                        tblCharacter newrow = new tblCharacter();
//                        newrow.Id = Guid.NewGuid();
//                        newrow.User_Id = Guid.NewGuid();
//                        character.Id = newrow.Id;
//                        dc.tblCharacters.Add(newrow);

//                        if (character.CharacterCurrency != null && character.CharacterCurrency.Any())
//                        {
//                            foreach (CharacterCurrency characterCurrency in character.CharacterCurrency)
//                            {
//                                tblCharacterCurrency? tblCharacterCurrency = dc.tblCharacterCurrencies.FirstOrDefault(a => a.Currency_Id == characterCurrency.Currency_Id && a.Character_Id == characterCurrency.Character_Id);
//                                if (tblCharacterCurrency != null)
//                                {
//                                    throw new Exception("No duplicate currency!!");
//                                }
//                                else
//                                {
//                                    tblCharacterCurrency = new tblCharacterCurrency();
//                                    tblCharacterCurrency.Id = Guid.NewGuid();
//                                    tblCharacterCurrency.Character_Id = characterCurrency.Character_Id;
//                                    tblCharacterCurrency.Currency_Id = characterCurrency.Currency_Id;
//                                    tblCharacterCurrency.Amount = characterCurrency.Amount;

//                                    characterCurrency.Id = tblCharacterCurrency.Id;
//                                    dc.tblCharacterCurrencies.Add(tblCharacterCurrency);
//                                }

//                            }
//                        }


//                        if (character.CharacterArmors != null && character.CharacterArmors.Any())
//                        {
//                            foreach (CharacterArmor characterArmor in character.CharacterArmors)
//                            {
//                                tblCharacterArmor? tblCharacterArmor = dc.tblCharacterArmors.FirstOrDefault(a => a.Armor_Id == characterArmor.Armor_Id && a.Character_Id == characterArmor.Character_Id);
//                                if (tblCharacterArmor != null)
//                                {
//                                    throw new Exception("No duplicate armor!!");
//                                }
//                                else
//                                {
//                                    tblCharacterArmor = new tblCharacterArmor();
//                                    tblCharacterArmor.Id = Guid.NewGuid();
//                                    tblCharacterArmor.Armor_Id = characterArmor.Armor_Id;
//                                    tblCharacterArmor.Character_Id = characterArmor.Character_Id;
//                                    tblCharacterArmor.Equipped = characterArmor.Equipped;

//                                    characterArmor.Id = tblCharacterArmor.Id;
//                                    dc.tblCharacterArmors.Add(tblCharacterArmor);
//                                }
//                            }
//                        }

//                        if (character.CharacterWeapons != null && character.CharacterWeapons.Any())
//                        {
//                            foreach (CharacterWeapon characterWeapons in character.CharacterWeapons)
//                            {
//                                tblCharacterWeapon? tblCharacterWeapon = dc.tblCharacterWeapons.FirstOrDefault(a => a.Weapon_Id == characterWeapons.Weapon_Id && a.Character_Id == characterWeapons.Character_Id);
//                                if (tblCharacterWeapon != null)
//                                {
//                                    throw new Exception("No duplicate weapons!!");
//                                }
//                                else
//                                {
//                                    tblCharacterWeapon = new tblCharacterWeapon();
//                                    tblCharacterWeapon.Id = Guid.NewGuid();
//                                    tblCharacterWeapon.Weapon_Id = characterWeapons.Weapon_Id;
//                                    tblCharacterWeapon.Character_Id = characterWeapons.Character_Id;
//                                    tblCharacterWeapon.Equipped = characterWeapons.Equipped;

//                                    characterWeapons.Id = tblCharacterWeapon.Id;
//                                    dc.tblCharacterWeapons.Add(tblCharacterWeapon);
//                                }
//                            }
//                        }



//                        if (character.CharacterWeaponTypeProficiencies != null && character.CharacterWeaponTypeProficiencies.Any())
//                        {
//                            foreach (CharacterWeapon characterWeapons in character.CharacterWeapons)
//                            {
//                                tblCharacterWeapon? tblCharacterWeapon = dc.tblCharacterWeapons.FirstOrDefault(a => a.Weapon_Id == characterWeapons.Weapon_Id && a.Character_Id == characterWeapons.Character_Id);
//                                if (tblCharacterWeapon != null)
//                                {
//                                    throw new Exception("No duplicate armor!!");
//                                }
//                                else
//                                {
//                                    tblCharacterWeapon = new tblCharacterWeapon();
//                                    tblCharacterWeapon.Id = Guid.NewGuid();
//                                    tblCharacterWeapon.Weapon_Id = characterWeapons.Weapon_Id;
//                                    tblCharacterWeapon.Character_Id = characterWeapons.Character_Id;
//                                    tblCharacterWeapon.Equipped = characterWeapons.Equipped;

//                                    characterWeapons.Id = tblCharacterWeapon.Id;
//                                    dc.tblCharacterWeapons.Add(tblCharacterWeapon);
//                                }
//                            }
//                        }













//                        results = dc.SaveChanges();
//                        if (rollback) { transaction.RollbackAsync(); }
//                        else { transaction.CommitAsync(); }
//                    }
//                });
//                return results;
//            }
//            catch (Exception)
//            {
//                throw;
//            }
//        }



//        public async static Task<int> Update(Character character, bool rollback = false)
//        {
//            try
//            {
//                IDbContextTransaction transaction = null;
//                using (DMDEntities dc = new DMDEntities())
//                {
//                    tblCharacter row = await dc.tblCharacters.FirstOrDefaultAsync(q => q.Id == character.Id);
//                    int results = 0;
//                    if (row != null)
//                    {
//                        if (rollback) { transaction = await dc.Database.BeginTransactionAsync().ConfigureAwait(false); }
//                        row.Character = character.Text;
//                        results = await dc.SaveChangesAsync().ConfigureAwait(false);
//                        if (transaction != null) { await transaction.RollbackAsync().ConfigureAwait(false); }
//                    }
//                    else
//                    {
//                        throw new Exception("Row was not found.");
//                    }
//                    return results;
//                }
//            }
//            catch (Exception)
//            {
//                throw;
//            }
//        }
//        public async static Task<int> Delete(Guid id, bool rollback = false)
//        {
//            try
//            {
//                using (DMDEntities dc = new DMDEntities())
//                {
//                    tblCharacter? row = await dc.tblCharacters.FirstOrDefaultAsync(q => q.Id == id).ConfigureAwait(false);
//                    int results = 0;
//                    if (row != null)
//                    {
//                        IDbContextTransaction transaction = await dc.Database.BeginTransactionAsync().ConfigureAwait(false);
//                        // Delete the characters from tblCharacterAnswer
//                        List<tblCharacterAnswer> characterAnswerRows = new List<tblCharacterAnswer>();
//                        characterAnswerRows.AddRange(dc.tblCharacterAnswers.Where(qa => qa.CharacterId == id));
//                        if (characterAnswerRows.Any())
//                        {
//                            foreach (tblCharacterAnswer character in characterAnswerRows)
//                            {
//                                dc.tblCharacterAnswers.Remove(character);
//                            }
//                        }
//                        // Delete the rows where the character is referenced in tblResponse
//                        List<tblResponse> responseRows = new();
//                        responseRows.AddRange(dc.tblResponses.Where(r => r.CharacterId == id));
//                        if (responseRows.Any())
//                        {
//                            foreach (tblResponse response in responseRows)
//                            {
//                                dc.tblResponses.Remove(response);
//                            }
//                        }
//                        // Delete the rows where the character is referenced in tblActivation
//                        List<tblUser> activationRows = new();
//                        activationRows.AddRange(dc.tblActivations.Where(a => a.CharacterId == id));
//                        if (activationRows.Any())
//                        {
//                            foreach (tblActivation activation in activationRows)
//                            {
//                                dc.tblActivations.Remove(activation);
//                            }
//                        }
//                        dc.tblCharacters.Remove(row);
//                        results = await dc.SaveChangesAsync().ConfigureAwait(false);
//                        if (rollback) { await transaction.RollbackAsync().ConfigureAwait(false); }
//                        else { await transaction.CommitAsync().ConfigureAwait(false); }
//                    }
//                    else
//                    {
//                        throw new Exception("Row not found.");
//                    }
//                    return results;
//                }
//            }
//            catch (Exception)
//            {
//                throw;
//            }
//        }
//    }
//}