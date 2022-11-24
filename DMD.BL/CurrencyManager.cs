using DMD.BL.Models;
using DMD.PL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DMD.BL
{
    public static class CurrencyManager 
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
                            .OrderBy(c => c.Value)
                            .ToList()
                            .ForEach(c => currencies.Add(new Currency()
                            {
                                Id = c.Id,
                                Name = c.Name,
                                Value = c.Value
                            }));
                    }
                });

                //List<Currency> sortedCurrencies = new List<Currency>();

                //foreach(Currency currency in currencies)
                //{

                //}

                return currencies;
            }
            catch (Exception)
            {

                throw;
            }
        }

    }
}
