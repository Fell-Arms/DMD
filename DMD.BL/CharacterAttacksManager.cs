using DMD.PL;
using Microsoft.EntityFrameworkCore.Storage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DMD.BL
{
    public class CharacterAttacksManager
    {
        public async static Task<int> Insert(Guid characterId, Guid attackId, int maxUses, bool rollback = false)
        {
            try
            {
                int results = 0;

                await Task.Run(() =>
                {
                    using (DMDEntities dc = new DMDEntities())
                    {
                        IDbContextTransaction transaction = dc.Database.BeginTransaction();
                        tblCharacterAttack tblCharacterAttack = new();
                        tblCharacterAttack.Id = Guid.NewGuid();
                        tblCharacterAttack.Character_Id = characterId;
                        tblCharacterAttack.Attack_Id = attackId;
                        tblCharacterAttack.CurrentUses = maxUses;

                        dc.tblCharacterAttacks.Add(tblCharacterAttack);

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
