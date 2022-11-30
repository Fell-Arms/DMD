using DMD.BL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DMD.BL.Test
{
    [TestClass]
    public class CharacterCurrencyManagerTests
    {
        //Test the ability to load data.
        [TestMethod]
        public void LoadTest()
        {
            //Run Async Task for Loading.
            Task.Run(async () =>
            {
                var task = await CharacterCurrencyManager.Load();
                List<Models.CharacterCurrency> charCurrency = task;
                Assert.AreEqual(3, charCurrency.ToList().Count);
            }).GetAwaiter().GetResult();
        }



        //This test method is used to test inserting data into the corresponding table and manager //ALTER COMMENTS TO SAY SPECIFIC ONES LATER.
        [TestMethod]
        public async Task InsertTest()
        {

            IEnumerable<CharacterCurrency> charCurrencyList = await CharacterCurrencyManager.Load();
            if (charCurrencyList.Any())
            {
                CharacterCurrency charCurrency = new CharacterCurrency()
                {
                    Id = Guid.NewGuid(),
                    Character_Id = charCurrencyList.First().Character_Id,
                    Currency_Id = charCurrencyList.First().Currency_Id,
                    Amount = 300,
                };

                int result = await CharacterCurrencyManager.Insert(charCurrency, true);
                Assert.IsTrue(result == 1);
            }
        }

    }
}
