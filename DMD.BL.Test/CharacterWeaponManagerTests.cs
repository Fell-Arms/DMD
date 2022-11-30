using DMD.BL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DMD.BL.Test
{
    [TestClass]
    public class CharacterWeaponManagerTests
    {
        /*
        //Test the ability to load data.
        [TestMethod]
        public void LoadTest()
        {
            //Run Async Task for Loading.
            Task.Run(async () =>
            {
                var task = await CharacterWeaponManager.Load();
                List<Models.CharacterWeapon> characterWeapons = task;
                Assert.AreEqual(3, characterWeapons.ToList().Count);
            }).GetAwaiter().GetResult();
        }


        //NEEDS TO BE MAJORLY FIXED UP
        //This test method is used to test inserting data into the corresponding table and manager //ALTER COMMENTS TO SAY SPECIFIC ONES LATER.
        [TestMethod]
        public async Task InsertTest()
        {

            IEnumerable<CharacterWeapon> charWeaponList = await CharacterWeaponManager.Load();
            if (charWeaponList.Any())
            {
                CharacterWeapon charWeapon = new CharacterWeapon()
                {
                    Id = Guid.NewGuid(),
                    Character_Id = charWeaponList.First().Character_Id,
                    Weapon_Id = charWeaponList.First().Weapon_Id,
                    Equipped = true,
                };

                int result = await CharacterWeaponManager.Insert(charWeapon, true);
                Assert.IsTrue(result == 1);
            }
        }
        */
    }
}
