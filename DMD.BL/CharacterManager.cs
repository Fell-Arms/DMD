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
                        newrow.User_Id = Guid.NewGuid();
                        character.Id = newrow.Id;
                        dc.tblCharacters.Add(newrow);

                        if (character.CharacterCurrency != null && character.CharacterCurrency.Any())
                        {
                            foreach (CharacterCurrency characterCurrency in character.CharacterCurrency)
                            {
                                tblCharacterCurrency? tblCharacterCurrency = dc.tblCharacterCurrencies.FirstOrDefault(a => a.Currency_Id == characterCurrency.Currency_Id && a.Character_Id == characterCurrency.Character_Id);
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
                                tblCharacterArmor? tblCharacterArmor = dc.tblCharacterArmors.FirstOrDefault(a => a.Armor_Id == characterArmor.Armor_Id && a.Character_Id == characterArmor.Character_Id);
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
                                tblCharacterWeapon? tblCharacterWeapon = dc.tblCharacterWeapons.FirstOrDefault(a => a.Weapon_Id == characterWeapons.Weapon_Id && a.Character_Id == characterWeapons.Character_Id);
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
                            foreach (CharacterWeapon characterWeapons in character.CharacterWeapons)
                            {
                                tblCharacterWeapon? tblCharacterWeapon = dc.tblCharacterWeapons.FirstOrDefault(a => a.Weapon_Id == characterWeapons.Weapon_Id && a.Character_Id == characterWeapons.Character_Id);
                                if (tblCharacterWeapon != null)
                                {
                                    throw new Exception("No duplicate armor!!");
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