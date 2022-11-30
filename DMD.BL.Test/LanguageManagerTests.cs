using DMD.BL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DMD.BL.Test
{
    [TestClass]
    public class LanguageManagerTests
    {
        //Test the ability to load data.
        [TestMethod]
        public async Task LoadTest()
        {
            //Run Async Task for Loading.
            Task.Run(async () =>
            {
                var task = await LanguageManager.Load();
                List<Models.Language> languages = task;
                Assert.AreEqual(3, languages.ToList().Count);
            }).GetAwaiter().GetResult();
        }

        /*
        //This test method is used to test inserting data into the corresponding table and manager //ALTER COMMENTS TO SAY SPECIFIC ONES LATER.
        [TestMethod]
        public async Task InsertTest()
        {

            IEnumerable<Language> languageList = await LanguageManager.Load();
            if (languageList.Any())
            {
                Language language = new Language()
                {
                    Id = Guid.NewGuid(),
                    Name = "Bobbathin",
                    Description = "TEST This is a language passed down from generations",
                };

                int result = await LanguageManager.Insert(language, true);
                Assert.IsTrue(result == 1);
            }
        }
        */
        
    }
}
