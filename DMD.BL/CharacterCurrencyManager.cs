using DMD.PL;
using Microsoft.EntityFrameworkCore.Storage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DMD.BL
{
    public class CharacterCurrencyManager
    {
        public async static Task<int> Insert(Guid characterId, Guid currencyId, int amount = 0, bool rollback = false)
        {
            try
            {
                int results = 0;

                await Task.Run(() =>
                {
                    using (DMDEntities dc = new DMDEntities())
                    {
                        IDbContextTransaction transaction = dc.Database.BeginTransaction();
                        tblCharacterCurrency tblCharacterCurrency = new();
                        tblCharacterCurrency.Id = Guid.NewGuid();
                        tblCharacterCurrency.Character_Id = characterId;
                        tblCharacterCurrency.Currency_Id = currencyId;
                        tblCharacterCurrency.Amount = amount;

                        dc.tblCharacterCurrencies.Add(tblCharacterCurrency);

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
