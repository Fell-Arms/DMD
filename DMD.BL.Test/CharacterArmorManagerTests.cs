using DMD.BL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DMD.BL.Test
{
    [TestClass]
    internal class CharacterArmorManagerTests
    {

        /*
        //Test the ability to load data.
        [TestMethod]
        public void LoadTest()
        {
            //Run Async Task for Loading.
            Task.Run(async () =>
            {
                var task = await CharacterArmorManager.Load();
                List<Models.Armor> armors = task;
                Assert.AreEqual(3, armors.ToList().Count);
            }).GetAwaiter().GetResult();
        }
        */


        /*
        //This test method is used to test inserting data into ArmorManager and into the Armor Table
        [TestMethod]
        public async Task InsertTest()
        {

            IEnumerable<CharacterArmor> charArmorList = await CharacterArmor.Load();
            //Character newrow = new Character(); //Instance of Character created
            if (charArmorList.Any())
            {
                CharacterArmor charArmor = new CharacterArmor()
                {
                    Id = Guid.NewGuid(),
                    Character_Id = charArmorList.First().Character_Id,
                    Armor_Id = charArmorList.First().Armor_Id,
                    Equipped = true
                };

                //needs fixing to match up with the insert method.
                int result = await CharacterArmorManager.Insert(charArmor, true);
                Assert.IsTrue(result == 1);
            }
        }
        */
    }
}
