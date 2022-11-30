using DMD.BL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DMD.BL.Test
{
    [TestClass]
    public class CurrencyManagerTests
    {
        //Test the ability to load data.
        [TestMethod]
        public async Task LoadTest()
        {
            //Run Async Task for Loading.
            Task.Run(async () =>
            {
                var task = await CurrencyManager.Load();
                List<Models.Currency> currencies = task;
                Assert.AreEqual(3, currencies.ToList().Count);
            }).GetAwaiter().GetResult();
        }

        /*
        //This test method is used to test inserting data into the corresponding table and manager //ALTER COMMENTS TO SAY SPECIFIC ONES LATER.
        [TestMethod]
        public async Task InsertTest()
        {

            IEnumerable<Currency> currencyList = await CurrencyManager.Load();
            if (currencyList.Any())
            {
                Currency currency = new Currency()
                {
                    Id = Guid.NewGuid(),
                    Name = "Bobbathin",
                    Value = "40000 bucks",
                };

                int result = await CurrencyManager.Insert(currency, true);
                Assert.IsTrue(result == 1);
            }
        }
        */
    }
}
