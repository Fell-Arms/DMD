using DMD.BL.Models;
using DMD.PL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DMD.BL
{
    public class CurrencyManager
    {

        public async static Task<List<Currency>> Load()
        {
            try
            {
                List<Currency> currencies = new List<Currency>();
                await Task.Run(() =>
                {
                    using (DMDEntities dc = new DMDEntities())
                    {
                        dc.tblCurrencies
                            .ToList()
                            .ForEach(c => currencies.Add(new Currency()
                            {
                                Id = c.Id,
                                Name = c.Name,
                                Value = c.Value
                            }));
                    }
                });
                return currencies;
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
