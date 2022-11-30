using DMD.BL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DMD.BL.Test
{
    [TestClass]
    public class CharacterWeaponProficiencyManagerTests
    {
        /*
        //Test the ability to load data.
        [TestMethod]
        public async Task LoadTest()
        {
            //Run Async Task for Loading.
            Task.Run(async () =>
            {
                var task = await CharacterWeaponProficiencyManager.Load();
                List<Models.CharacterWeaponTypeProficiency> characterWeaponTypeProficiencies = task;
                Assert.AreEqual(3, characterWeaponTypeProficiencies.ToList().Count);
            }).GetAwaiter().GetResult();
        }


        //NEEDS TO BE MAJORLY FIXED UP
        //This test method is used to test inserting data into the corresponding table and manager //ALTER COMMENTS TO SAY SPECIFIC ONES LATER.
        [TestMethod]
        public async Task InsertTest()
        {

            IEnumerable<CharacterWeaponTypeProficiency> charWeaponTypeProficiencyList = await CharacterWeaponProficiencyManager.Load();
            if (charWeaponTypeProficiencyList.Any())
            {
                CharacterWeaponTypeProficiency charWeaponProficiency = new CharacterWeaponTypeProficiency()
                {
                    Id = Guid.NewGuid(),
                    Character_Id = charWeaponTypeProficiencyList.First().Character_Id,
                    WeaponType_Id = charWeaponTypeProficiencyList.First().WeaponType_Id,
                };

                int result = await CharacterWeaponProficiencyManager.Insert(charWeaponProficiency, true);
                Assert.IsTrue(result == 1);
            }
        }
        */
    }
}
