using DMD.BL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DMD.BL.Test
{
    [TestClass]
    public class CharacterLanguagesManagerTests
    {
        /*
        //Test the ability to load data.
        [TestMethod]
        public async Task LoadTest()
        {
            //Run Async Task for Loading.
            Task.Run(async () =>
            {
                var task = await CharacterLanguagesManager.Load();
                List<Models.CharacterLanguage> charLanguages = task;
                Assert.AreEqual(3, charLanguages.ToList().Count);
            }).GetAwaiter().GetResult();
        }



        //This test method is used to test inserting data into the corresponding table and manager //ALTER COMMENTS TO SAY SPECIFIC ONES LATER.
        [TestMethod]
        public async Task InsertTest()
        {

            IEnumerable<CharacterLanguage> charLanguageList = await CharacterLanguagesManager.Load();
            if (charLanguageList.Any())
            {
                CharacterLanguage charLanguage = new CharacterLanguage()
                {
                    Id = Guid.NewGuid(),
                    Character_Id = charLanguageList.First().Character_Id,
                    Language_Id = charLanguageList.First().Language_Id
                };

                int result = await CharacterLanguagesManager.Insert(charLanguage, true);
                Assert.IsTrue(result == 1);
            }
        }
        */
    }
}
