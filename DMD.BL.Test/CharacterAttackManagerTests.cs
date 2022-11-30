using DMD.BL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DMD.BL.Test
{
    [TestClass]
    public class CharacterAttackManagerTests
    {
        /*
        //Test the ability to load data.
        [TestMethod]
        public async Task LoadTest()
        {
            //Run Async Task for Loading.
            Task.Run(async () =>
            {
                var task = await CharacterAttacksManager.Load();
                List<Models.CharacterAttack> charAttacks = task;
                Assert.AreEqual(3, charAttacks.ToList().Count);
            }).GetAwaiter().GetResult();
        }



        //This test method is used to test inserting data into the corresponding table and manager //ALTER COMMENTS TO SAY SPECIFIC ONES LATER.
        [TestMethod]
        public async Task InsertTest()
        {

            IEnumerable<CharacterAttack> charAttackList = await CharacterAttacksManager.Load();
            if (charAttackList.Any())
            {
                CharacterAttack charAttack = new CharacterAttack()
                {
                    Id = Guid.NewGuid(),
                    Character_Id = charAttackList.First().Character_Id,
                    Attack_Id = charAttackList.First().Attack_Id,
                    CurrentUses = 3,
                };

                int result = await CharacterAttacksManager.Insert(charAttack, true);
                Assert.IsTrue(result == 1);
            }
        }
        */
    }
}
