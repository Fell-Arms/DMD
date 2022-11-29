using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DMD.BL.Models;
using DMD.PL;
using Microsoft.EntityFrameworkCore.Storage;

namespace DMD.BL.Test
{
    [TestClass]
    public class CharacterManagerTests
    {
        //Protected instances of DMDEntities and IDbContextTransaction.
        protected DMDEntities dc;
        protected IDbContextTransaction transaction;

        //Test the ability to load data in CharacterManager
        [TestMethod]
        public void LoadTest()
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
            if(characterList.Any())
            {
                Character character = new Character()
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



            /*
            Models.Character character = new Models.Character();

            character.Id = Guid.NewGuid();                      
            character.UserId = userList[0].Id;                 //FOLLOW EXAMPLE FOR LOADING A GUID  //Manager methods are already using awaited task, NEEDS TO BE REMOVED SO IT WILL WORK.
            character.RaceId = userList[0].Id;                   //NEED TO USE A PRE-EXISTING ID VALUE WITHIN THE TABLE FOR A NEW ROW. (APPLIES TO ALL LINKING TABLES, REFER TO ERD FOR HELP.)
            character.CharacterLevelId = userList[0].Id;         //NEED TO FETCH THE ROW FOR A GUID. 
            character.FirstName = "Jefferson";
            character.LastName = "Geffy";
            character.MaxHitpoints = 3;
            character.CurrentHitpoints = 2;
            character.Background = "www.background.com";
            character.Experience = 25;
            character.ImagePath = "www.portraitimagetest.com/aaaa";

            int results =UserManager.Insert(userList, true);
            Assert.IsTrue(results > 0);
            */


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
