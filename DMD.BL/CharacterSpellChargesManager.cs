using DMD.PL;
using Microsoft.EntityFrameworkCore.Storage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DMD.BL
{
    public class CharacterSpellChargesManager
    {
        public async static Task<int> Insert(Guid characterId, Guid spellChargesByLevelId, int maxCasts, bool rollback = false)
        {
            try
            {
                int results = 0;

                await Task.Run(() =>
                {
                    using (DMDEntities dc = new DMDEntities())
                    {
                        IDbContextTransaction transaction = dc.Database.BeginTransaction();
                        tblCharacterSpellCharge tblCharacterSpellCharge = new();
                        tblCharacterSpellCharge.Id = Guid.NewGuid();
                        tblCharacterSpellCharge.Character_Id = characterId;
                        tblCharacterSpellCharge.Spell_Charges_By_Level_Id = spellChargesByLevelId;
                        tblCharacterSpellCharge.ChargesAvaliable = maxCasts;

                        dc.tblCharacterSpellCharges.Add(tblCharacterSpellCharge);

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
