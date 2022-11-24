using DMD.PL;
using Microsoft.EntityFrameworkCore.Storage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DMD.BL
{
    public class CharacterStatsManager
    {
        public async static Task<int> Insert(Guid characterId, Guid statId, int value, bool rollback = false)
        {
            try
            {
                int results = 0;

                await Task.Run(() =>
                {
                    using (DMDEntities dc = new DMDEntities())
                    {
                        IDbContextTransaction transaction = dc.Database.BeginTransaction();
                        tblCharacterStat tblCharacterStat = new();
                        tblCharacterStat.Id = Guid.NewGuid();
                        tblCharacterStat.Character_Id = characterId;
                        tblCharacterStat.Stats_Id = statId;
                        tblCharacterStat.Value = value;

                        dc.tblCharacterStats.Add(tblCharacterStat);

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
