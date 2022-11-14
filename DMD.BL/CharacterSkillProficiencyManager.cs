using DMD.PL;
using Microsoft.EntityFrameworkCore.Storage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DMD.BL
{
    public class CharacterSkillProficiencyManager
    {
        public async static Task<int> Insert(Guid characterId, Guid skillId, bool validRow = true, bool rollback = false)
        {
            try
            {
                int results = 0;

                await Task.Run(() =>
                {
                    using (DMDEntities dc = new DMDEntities())
                    {
                        IDbContextTransaction transaction = dc.Database.BeginTransaction();
                        tblCharacterSkillProficiency tblCharacterSkillProficiency = new();
                        tblCharacterSkillProficiency.Character_Id = characterId;
                        tblCharacterSkillProficiency.Skill_Id = skillId;
                        tblCharacterSkillProficiency.ValidRow = validRow;

                        dc.tblCharacterSkillProficiencies.Add(tblCharacterSkillProficiency);

                        results = dc.SaveChanges();
                        if (rollback) { transaction.Rollback(); }
                        else { transaction.Commit(); }
                    }
                });

                return results;
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
