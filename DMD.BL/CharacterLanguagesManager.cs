using DMD.PL;
using Microsoft.EntityFrameworkCore.Storage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DMD.BL
{
    public class CharacterLanguagesManager
    {
        public async static Task<int> Insert(Guid characterId, Guid languageId, bool rollback = false)
        {
            try
            {
                int results = 0;

                await Task.Run(() =>
                {
                    using (DMDEntities dc = new DMDEntities())
                    {
                        IDbContextTransaction transaction = dc.Database.BeginTransaction();
                        tblCharacterLanguage tblCharacterLanguage = new tblCharacterLanguage();
                        tblCharacterLanguage.Id = Guid.NewGuid();
                        tblCharacterLanguage.Character_Id = characterId;
                        tblCharacterLanguage.Language_Id = languageId;

                        dc.tblCharacterLanguages.Add(tblCharacterLanguage);

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
