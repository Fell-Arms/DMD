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
                                FirstName = c.FirstName,
                                LastName = c.LastName,
                                MaxHitpoints = c.MaxHitpoints,
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
                                }
                                //Armor armor = new Armor
                                //{
                                //    Id = ca.Armor_Id,
                                //    ArmorStyle_Id = ca.Armor.ArmorStyle_Id,
                                //    ArmorType_Id = ca.Armor.ArmorType_Id,
                                //    ArmorClassBonus = ca.Armor.ArmorClassBonus,
                                //    MovementPenalty = ca.Armor.MovementPenalty,
                                //    Cost = ca.Armor.Cost
                                //};
                                character.CharacterArmors.Add(armor);
                            }
                            // Create a list of Activations
                            character.Activations = new List<Activation>();
                            foreach (tblActivation act in q.tblActivations.ToList())
                            {
                                Activation activation = new Activation
                                {
                                    Id = act.Id,
                                    CharacterId = act.CharacterId,
                                    ActivationCode = act.ActivationCode,
                                    StartDate = act.StartDate,
                                    EndDate = act.EndDate
                                };
                                character.Activations.Add(activation);
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
                BL.Models.Character character = new Models.Character();
                await Task.Run(() =>
                {
                    using (DMDEntities dc = new DMDEntities())
                    {
                        tblCharacter tblCharacter = dc.tblCharacters.Where(q => q.Id == id).FirstOrDefault();
                        if (tblCharacter != null)
                        {
                            // Fill table row values into object
                            



                            character.CharacterArmors = new List<CharacterArmor>();
                            character.CharacterCurrency = new List<CharacterCurrency>();
                            character.CharacterWeapons = new List<CharacterWeapon>();
                            character.CharacterWeaponTypeProficiencies = new List<CharacterWeaponTypeProficiency>();
                            character.CharacterSpellCharges = new List<CharacterSpellCharges>();
                            character.CharacterSpells = new List<CharacterSpells>();
                            character.CharacterClasses = new List<CharacterClasses>();
                            character.CharacterAttacks = new List<CharacterAttacks>();
                            character.CharacterStats = new List<CharacterStats>();
                            character.CharacterSkillProficiencies = new List<CharacterSKillProficiency>();
                            character.CharacterLanguages = new List<CharacterLanguages>();

                      


                            character.Activations = new();
                            try
                            {
                                List<tblCharacterAnswer> tblCharacterAnswers = new List<tblCharacterAnswer>();
                                List<tblActivation> tblActivations = new();
                                tblCharacterAnswers.AddRange(dc.tblCharacterAnswers.Where(qa => qa.CharacterId == id));
                                tblActivations.AddRange(dc.tblActivations.Where(a => a.CharacterId == id));
                                foreach (tblCharacterAnswer qa in tblCharacterAnswers)
                                {
                                    Answer answer = new Answer
                                    {
                                        Id = qa.AnswerId,
                                        IsCorrect = qa.IsCorrect,
                                        Text = qa.Answer.Answer
                                    };
                                    character.Answers.Add(answer);
                                }
                                foreach (tblActivation a in tblActivations)
                                {
                                    Activation activation = new Activation
                                    {
                                        Id = a.Id,
                                        StartDate = a.StartDate,
                                        EndDate = a.EndDate,
                                        ActivationCode = a.ActivationCode
                                    };
                                    character.Activations.Add(activation);
                                }
                            }
                            catch (Exception)
                            {
                                throw;
                            }
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
        public async static Task<Character> Load(string activationCode)
        {
            try
            {
                Character character = new();
                await Task.Run(() =>
                {
                    using (DMDEntities dc = new())
                    {
                        Activation activation = new();
                        tblActivation? tblActivation = dc.tblActivations.Where(a => a.ActivationCode == activationCode).FirstOrDefault();
                        if (tblActivation == null) { throw new ArgumentNullException("Activation code not found.", nameof(tblActivation)); }
                        if (DateTime.Now > tblActivation.EndDate) { throw new Exception("This activation code has already expired."); }
                        activation.Id = tblActivation.Id;
                        activation.StartDate = tblActivation.StartDate;
                        activation.EndDate = tblActivation.EndDate;
                        activation.ActivationCode = tblActivation.ActivationCode;
                        tblCharacter? tblCharacter = dc.tblCharacters.Where(q => q.Id == tblActivation.CharacterId).FirstOrDefault();
                        if (tblCharacter == null) { throw new Exception("Character not found."); }
                        character.Id = tblCharacter.Id;
                        character.Text = tblCharacter.Character;
                        character.Answers = new();
                        character.Activations = new();
                        character.Activations.Add(activation);
                        List<tblCharacterAnswer> tblCharacterAnswers = new();
                        tblCharacterAnswers.AddRange(dc.tblCharacterAnswers.Where(qa => qa.CharacterId == tblCharacter.Id));
                        foreach (tblCharacterAnswer qa in tblCharacterAnswers)
                        {
                            Answer answer = new Answer
                            {
                                Id = qa.AnswerId,
                                IsCorrect = qa.IsCorrect,
                                Text = qa.Answer.Answer
                            };
                            character.Answers.Add(answer);
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
                        dc.tblCharacters.Add(newrow);

                        if (character.CharacterCurrency != null && character.CharacterCurrency.Any())
                        {
                            foreach (CharacterCurrency characterCurrency in character.CharacterCurrency)
                            {
                                tblCharacterCurrency? tblCharacterCurrency = dc.tblCharacterCurrencies.FirstOrDefault(cc => cc.Currency_Id == characterCurrency.Currency_Id && cc.Character_Id == characterCurrency.Character_Id);
                                if ( tblCharacterCurrency != null)
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
                                    tblCharacterArmor.Armor_Id = characterArmor.Armor_Id  ;
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
                                    throw new Exception("No duplicate armor!!");
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
                            foreach (CharacterSpellCharges characterSpellCharges in character.CharacterSpellCharges)
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





                        if (character.CharacterSpells != null && character.CharacterSpells.Any())
                        {
                            foreach (CharacterSpells characterSpells in character.CharacterSpells)
                            {
                                tblCharacterSpell? tblCharacterSpell = dc.tblCharacterSpells.FirstOrDefault(cspl => cspl.Spell_Id == characterSpells.Spell_Id && cspl.Character_Id == characterSpells.Character_Id);
                                if (tblCharacterSpell != null)
                                {
                                    throw new Exception("No duplicate spells!!");
                                }
                                else
                                {
                                    tblCharacterSpell = new tblCharacterSpell();
                                    tblCharacterSpell.Id = Guid.NewGuid();
                                    tblCharacterSpell.Spell_Id = tblCharacterSpell.Spell_Id;

                                    characterSpells.Id = tblCharacterSpell.Id;
                                    dc.tblCharacterSpells.Add(tblCharacterSpell);
                                }
                            }
                        }



                        if (character.CharacterClasses != null && character.CharacterClasses.Any())
                        {
                            foreach (CharacterClasses characterClasses in character.CharacterClasses)
                            {
                                tblCharacterClass? tblCharacterClass = dc.tblCharacterClasses.FirstOrDefault(cca => cca.Class_Id == characterClasses.Class_Id && cca.Character_Id == characterClasses.Character_Id);
                                if (tblCharacterClass != null)
                                {
                                    throw new Exception("No duplicate spells!!");
                                }
                                else
                                {
                                    tblCharacterClass = new tblCharacterClass();
                                    tblCharacterClass.Id = Guid.NewGuid();
                                    tblCharacterClass.Class_Level = tblCharacterClass.Class_Level;
                                    tblCharacterClass.Class_Id = tblCharacterClass.Class_Id;

                                    characterClasses.Id = tblCharacterClass.Id;
                                    dc.tblCharacterClasses.Add(tblCharacterClass);
                                }
                            }
                        }


                        if (character.CharacterAttacks != null && character.CharacterAttacks.Any())
                        {
                            foreach (CharacterAttacks characterAttacks in character.CharacterAttacks)
                            {
                                tblCharacterAttack? tblCharacterAttack = dc.tblCharacterAttacks.FirstOrDefault(caa => caa.Attack_Id == characterAttacks.Attack_Id && caa.Character_Id == characterAttacks.Character_Id);
                                if (tblCharacterAttack != null)
                                {
                                    throw new Exception("No duplicate attacks!!");
                                }
                                else
                                {
                                    tblCharacterAttack = new tblCharacterAttack();
                                    tblCharacterAttack.Id = Guid.NewGuid();
                                    tblCharacterAttack.Attack_Id = tblCharacterAttack.Attack_Id;
                                    tblCharacterAttack.CurrentUses = tblCharacterAttack.CurrentUses;

                                    characterAttacks.Id = tblCharacterAttack.Id;
                                    dc.tblCharacterAttacks.Add(tblCharacterAttack);
                                }
                            }
                        }


                        if (character.CharacterStats != null && character.CharacterStats.Any())
                        {
                            foreach (CharacterStats CharacterStats in character.CharacterStats)
                            {
                                tblCharacterStat? tblCharacterStat = dc.tblCharacterStats.FirstOrDefault(cst => cst.Stats_Id == cst.Stats_Id && cst.Character_Id == CharacterStats.Character_Id);
                                if (tblCharacterStat != null)
                                {
                                    throw new Exception("No duplicate stats!!");
                                }
                                else
                                {
                                    tblCharacterStat = new tblCharacterStat();
                                    tblCharacterStat.Id = Guid.NewGuid();
                                    tblCharacterStat.Stats_Id = tblCharacterStat.Stats_Id;
                                    tblCharacterStat.Value = tblCharacterStat.Value;

                                    CharacterStats.Id = tblCharacterStat.Id;
                                    dc.tblCharacterStats.Add(tblCharacterStat);
                                }
                            }
                        }

                        if (character.CharacterSkillProficiencies != null && character.CharacterSkillProficiencies.Any())
                        {
                            foreach (CharacterSKillProficiency characterSKillProficiency in character.CharacterSkillProficiencies)
                            {
                                tblCharacterSkillProficiency? tblCharacterSkillProficiency = dc.tblCharacterSkillProficiencies.FirstOrDefault(csp => csp.Skill_Id == csp.Skill_Id && csp.Character_Id == characterSKillProficiency.Character_Id);
                                if (tblCharacterSkillProficiency != null)
                                {
                                    throw new Exception("No duplicate skill proficiency!!");
                                }
                                else
                                {
                                    tblCharacterSkillProficiency = new tblCharacterSkillProficiency();
                                    tblCharacterSkillProficiency.Id = Guid.NewGuid();
                                    tblCharacterSkillProficiency.Skill_Id = tblCharacterSkillProficiency.Skill_Id;

                                    characterSKillProficiency.Id = characterSKillProficiency.Id;
                                    dc.tblCharacterSkillProficiencies.Add(tblCharacterSkillProficiency);
                                }
                            }
                        }

                        if (character.CharacterLanguages != null && character.CharacterLanguages.Any())
                        {
                            foreach (CharacterLanguages characterLanguages in character.CharacterLanguages)
                            {
                                tblCharacterLanguage? tblCharacterLanguage = dc.tblCharacterLanguages.FirstOrDefault(cl => cl.Language_Id == cl.Language_Id && cl.Character_Id == characterLanguages.Character_Id);
                                if (characterLanguages != null)
                                {
                                    throw new Exception("No duplicate language!!");
                                }
                                else
                                {
                                    tblCharacterLanguage = new tblCharacterLanguage();
                                    tblCharacterLanguage.Id = Guid.NewGuid();
                                    tblCharacterLanguage.Language_Id = tblCharacterLanguage.Language_Id;

                                    characterLanguages.Id = characterLanguages.Id;
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
    }
}