using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DMD.BL.Models;
using DMD.PL;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DMD.BL.Test
{
    [TestClass]
    public class CharacterManagerTests
    {

        //Test the ability to load data in CharacterManager
        [TestMethod]
        public async Task LoadTest()
        {
            IEnumerable<Character> characterList = await CharacterManager.Load();

            Assert.IsNotNull(characterList);

            Character character = characterList.Where(c => c.LastName == "Bobbinson").First();

            Assert.IsNotNull(characterList);

            Assert.IsTrue(characterList.Any());

            Assert.IsTrue(character.CharacterStats.Any());

            Assert.IsTrue(character.CharacterLanguages.Any());
        }

        [TestMethod]
        public async Task LoadByUserIdTest()
        {
            IEnumerable<User> userList = await UserManager.Load();

            User user = userList.First(u => u.UserName == "bfoote");

            IEnumerable<Character> characterList = await CharacterManager.LoadByUserId(user.Id);

            foreach(Character character in characterList)
            {
                Assert.IsTrue(character.UserId == user.Id);
            }
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
        public async Task InsertTest()
        {

            IEnumerable<User> userList = await UserManager.Load();

            //CharacterManager Async Task insert test

            int results = await CharacterManager.Insert(
                new Models.Character {
                    Id = Guid.NewGuid(),
                    UserId = userList.First().Id,
                    RaceId = Guid.NewGuid(),
                    CharacterLevelId = 1,
                    FirstName = "Jefferson",
                    LastName = "Geffy",
                    MaxHitpoints = 3,
                    CurrentHitpoints = 2,
                    Background = "www.background.com",
                    Experience = 25,
                    ImagePath = "www.portraitimagetest.com/aaaa"
                }, true);
            Assert.IsTrue(results > 0);


            /* SAVE THIS FOR CHARACTERARMOR TEST CLASS.
            //CharacterArmor Async Task insert test
            Task.Run(async () =>
            {
                int results2 = await CharacterArmorManager.Insert(
                    new Models.CharacterArmor
                    {
                        Id = Guid.NewGuid(),
                        Character_Id = Guid.NewGuid(),
                        Armor_Id = Guid.NewGuid(),
                        Equipped = false
                    }, true);
                Assert.IsTrue(results2 > 0);
            });
            */
        }
    }
}
