using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DMD.BL.Models;

namespace DMD.BL.Test
{
    [TestClass]
    public class CharacterManagerTests
    {

        //Test the ability to load data in CharacterManager
        [TestMethod]
        public void LoadTest()
        {
            //Run Async Task for Loading.
            Task.Run(async () =>
            {
                var task = await CharacterManager.Load();
                //IEnumerable<Models.Character> characters = task;
                List<Models.Character> characters = task;
                Assert.AreEqual(3, characters.ToList().Count);
            }).GetAwaiter().GetResult();


            /*
            //Run Async Task for Loading in CharacterArmor
            Task.Run(async () =>
            {
                var task2 = await CharacterArmorManager.Load();
                IEnumerable<Models.CharacterArmor> cnaracterArmors = task2;
                Assert.AreEqual(3, armors.ToList().Count);
            }).GetAwaiter().GetResult();
            */
            

        }


        /* THIS IS A MESS, MAY NEED HELP
        //Test the Ability to Insert Data
        [TestClass]
        public void InsertTest()
        {
            Task.Run(async () =>
            {
                int results = await ModelManager.Insert(new Models.Model { Description = "NewModel" }, true);
                Assert.IsTrue(results > 0);

            });

        }
        */


        //This method is used to insert data and test inserting data where applicable for each table.
        [TestMethod]
        public void InsertTest()
        {
            //CharacterManager Async Task
            Task.Run(async () =>
            {
                int results = await CharacterManager.Insert(
                    new Models.Character {
                        Id = Guid.NewGuid(),
                        UserId = Guid.NewGuid(),
                        RaceId = Guid.NewGuid(),
                        CharacterLevelId = Guid.NewGuid(),
                        FirstName = "Jefferson",
                        LastName = "Geffy",
                        MaxHitpoints = 3,
                        CurrentHitpoints = 2,
                        Background = "www.background.com",
                        Experience = 25,
                        ImagePath = "www.portraitimagetest.com/aaaa"
                    }, true);
                Assert.IsTrue(results > 0);
            });
        }




    }
}
