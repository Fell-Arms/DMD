using DMD.BL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DMD.BL.Test
{
    [TestClass]
    public class CharacterClassSpellManagerTests
    {
        /*
        //Test the ability to load data.
        [TestMethod]
        public async Task LoadTest()
        {
            //Run Async Task for Loading.
            Task.Run(async () =>
            {
                var task = await CharacterClassSpellsManager.Load();
                List<Models.CharacterClassSpell> charClassSpells = task;
                Assert.AreEqual(3, charClassSpells.ToList().Count);
            }).GetAwaiter().GetResult();
        }



        //This test method is used to test inserting data into the corresponding table and manager //ALTER COMMENTS TO SAY SPECIFIC ONES LATER.
        [TestMethod]
        public async Task InsertTest()
        {

            IEnumerable<CharacterClassSpell> charClassSpellList = await CharacterClassSpellsManager.Load();
            if (charClassSpellList.Any())
            {
                CharacterClassSpell charClassSpell = new CharacterClassSpell()
                {
                    Id = Guid.NewGuid(),
                    Character_Id = charClassSpellList.First().Character_Id,
                    ClassSpell_Id = charClassSpellList.First().ClassSpell_Id,
                };

                int result = await CharacterClassSpellsManager.Insert(charClassSpell, true);
                Assert.IsTrue(result == 1);
            }
        }
        */
    }
}
