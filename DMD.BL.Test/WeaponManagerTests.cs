using DMD.BL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DMD.BL.Test
{
    [TestClass]
    internal class WeaponManagerTests
    {
        //Test the ability to load data.
        [TestMethod]
        public async Task LoadTest()
        {
            //Run Async Task for Loading.
            Task.Run(async () =>
            {
                var task = await WeaponManager.Load();
                List<Models.Weapon> weapons = task;
                Assert.AreEqual(3, weapons.ToList().Count);
            }).GetAwaiter().GetResult();
        }

        
        /*
        //This test method is used to test inserting data into the corresponding table and manager //ALTER COMMENTS TO SAY SPECIFIC ONES LATER.
        [TestMethod]
        public async Task InsertTest()
        {

            IEnumerable<Weapon> weaponList = await WeaponManager.Load();
            if (weaponList.Any())
            {
                Weapon weapon = new Weapon()
                {
                    Id = Guid.NewGuid(),
                    WeaponType_Id = weaponList.First().WeaponType_Id,
                    Stats_Id = weaponList.First().Stats_Id,
                    WeaponDamageType_Ids = weaponList.First().WeaponDamageType_Ids,
                    Name = "TEST weapon name bobathina"
                    Cost = 300,
                };

                int result = await WeaponManager.Insert(weapon, true);
                Assert.IsTrue(result == 1);
            }
        }
        */
        
    }
}
