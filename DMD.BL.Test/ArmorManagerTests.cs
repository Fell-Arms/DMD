using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DMD.BL.Models;

namespace DMD.BL.Test
{
    [TestClass]
    public class ArmorManagerTests
    {
        //Test the ability to load data.
        [TestMethod]
        public void LoadTest()
        {
            //Run Async Task for Loading.
            Task.Run(async () =>
            {
                var task = await ArmorManager.Load();
                List<Models.Armor> armors = task;
                Assert.AreEqual(3, armors.ToList().Count);
            }).GetAwaiter().GetResult();
        }


        /*
        //COMMENT OUT
        //This test method is used to test inserting data into ArmorManager and into the Armor Table
        [TestMethod]
        public async Task InsertTest()
        {

            IEnumerable<Armor> armorList = await ArmorManager.Load();
            //Character newrow = new Character(); //Instance of Character created
            if (armorList.Any())
            {
                Armor armor = new Armor()
                {
                    Id = armorList.First().Id,
                    ArmorStyle_Id = armorList.First().ArmorStyle_Id,
                    ArmorType_Id = armorList.First().ArmorType_Id,
                    ArmorClassBonus = 200,
                    MovementPenalty = 200,
                    Cost = 200
                };

                int result = await ArmorManager.Insert(armor, true);
                Assert.IsTrue(result == 1);
            }
        }
        */
        
    }

}
