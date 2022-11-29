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
                    Id = characterList.First().Id,
                    UserId = characterList.First().UserId,
                    RaceId = characterList.First().RaceId,
                    CharacterLevelId = characterList.First().CharacterLevelId,
                    FirstName = "TestBilly",
                    LastName = "TestGeffy",
                    MaxHitpoints = 300,
                    CurrentHitpoints = 200,
                    Background = "www.background.com",
                    Experience = 25000,
                    ImagePath = "www.portraitimageTEST.com"
                };

                int result = await CharacterManager.Insert(character, true);
                Assert.IsTrue(result == 1);
            }
        }

}
