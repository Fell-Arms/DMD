using DMD.BL.Models;
using DMD.PL;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage;
using System;
using System.Collections.Generic;
using System.Linq;
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
                            character.Id = tblCharacter.Id;
                            character.Text = tblCharacter.Character;
                            character.Answers = new List<Answer>();
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
        public async static Task<Character> LoadByActivationCode(string activationCode)
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
                        newrow.Character = character.Text;
                        character.Id = newrow.Id;
                        dc.tblCharacters.Add(newrow);
                        if (character.Answers != null && character.Answers.Any())
                        {
                            foreach (Answer answer in character.Answers)
                            {
                                tblAnswer? answerRow = dc.tblAnswers.FirstOrDefault(a => a.Answer == answer.Text);
                                if (answerRow != null)
                                {
                                    answer.Id = answerRow.Id;
                                }
                                else
                                {
                                    answerRow = new tblAnswer();
                                    answerRow.Id = Guid.NewGuid();
                                    answerRow.Answer = answer.Text;
                                    answer.Id = answerRow.Id;
                                    dc.tblAnswers.Add(answerRow);
                                }
                                tblCharacterAnswer characterAnswerRow = new tblCharacterAnswer();
                                characterAnswerRow.Id = Guid.NewGuid();
                                characterAnswerRow.CharacterId = character.Id;
                                characterAnswerRow.AnswerId = answer.Id;
                                characterAnswerRow.IsCorrect = answer.IsCorrect;
                                dc.tblCharacterAnswers.Add(characterAnswerRow);
                            }
                        }
                        if (character.Activations != null && character.Activations.Any())
                        {
                            foreach (Activation activation in character.Activations)
                            {
                                tblActivation? activationRow = dc.tblActivations.FirstOrDefault(a => a.ActivationCode == activation.ActivationCode);
                                if (activationRow != null)
                                {
                                    throw new Exception("Activation code in use.");
                                }
                                else
                                {
                                    activationRow = new tblActivation();
                                    activationRow.Id = Guid.NewGuid();
                                    activationRow.CharacterId = character.Id;
                                    activationRow.ActivationCode = activation.ActivationCode;
                                    activationRow.StartDate = DateTime.Now;
                                    activationRow.EndDate = DateTime.Now.AddDays(7);
                                    dc.tblActivations.Add(activationRow);
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