using DMD.PL;
using Microsoft.EntityFrameworkCore.Storage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DMD.BL
{
    public class CharacterClassSpellsManager
    {
        public async static Task<int> Insert(Guid characterId, Guid classSpellId, bool rollback = false)
        {
            try
            {
                int results = 0;

                await Task.Run(() =>
                {
                    using (DMDEntities dc = new DMDEntities())
                    {
                        IDbContextTransaction transaction = dc.Database.BeginTransaction();
                        tblCharacterClassSpell tblCharacterClassSpell = new();
                        tblCharacterClassSpell.Id = Guid.NewGuid();
                        tblCharacterClassSpell.Character_Id = characterId;
                        tblCharacterClassSpell.ClassSpells_Id = classSpellId;

                        dc.tblCharacterClassSpells.Add(tblCharacterClassSpell);

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
