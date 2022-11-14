using DMD.PL;
using Microsoft.EntityFrameworkCore.Storage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DMD.BL
{
    public class CharacterClassesManager
    {
        public async static Task<int> Insert(Guid characterId, Guid classId, int classLevel = 1, bool rollback = false)
        {
            try
            {
                int results = 0;

                await Task.Run(() =>
                {
                    using (DMDEntities dc = new DMDEntities())
                    {
                        IDbContextTransaction transaction = dc.Database.BeginTransaction();
                        tblCharacterClass tblCharacterClass = new();
                        tblCharacterClass.Id = Guid.NewGuid();
                        tblCharacterClass.Character_Id = characterId;
                        tblCharacterClass.Class_Id = classId;
                        tblCharacterClass.Class_Level = classLevel;

                        dc.tblCharacterClasses.Add(tblCharacterClass);

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
