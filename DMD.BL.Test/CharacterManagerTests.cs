using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DMD.BL.Models;
using DMD.PL;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DMD.BL.Test
{
    [TestClass]
    public class CharacterManagerTests
    {
        //Protected Fields of DMDEntities and IDbContextTransaction.
        protected DMDEntities dc;
        protected IDbContextTransaction transaction;

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


        //create a LOADBYID METHOD can load using generic ID instead from characterList(?)


        //Test the ability to load data in CharacterManager
        [TestMethod]
        public void LoadTest2()
        {
            //Run Async Task for Loading.
            Task.Run(async () =>
            {
                var task = await CharacterManager.Load();
                List<Models.Character> characters = task;
                Assert.AreEqual(3, characters.ToList().Count);
            }).GetAwaiter().GetResult();
        }



        //This test method is used to test inserting data into CharacterManager and into the Character Table
        [TestMethod]
        public async Task InsertTest()
        {
            IEnumerable<Character> characterList = await CharacterManager.Load();
            //Character newrow = new Character(); //Instance of Character created
            if (characterList.Any())
            {
                Character character = new Character()
                {
                    Id = Guid.NewGuid(),
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
}
