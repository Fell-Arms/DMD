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
                IEnumerable<Models.Armor> armors = task;
                Assert.AreEqual(3, armors.ToList().Count);
            }).GetAwaiter().GetResult();
        }


        //Insert test for ArmorManager
        [TestMethod]
        public void InsertTest()
        {

            List<Character> userList = UserManager.Load(); //FOLLOW THIS EXAMPLE FOR ALL THE INSERTS.
            Character newrow = new Character(); //Instance of Character created

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

            int results = UserManager.Insert(userList, true);
            Assert.IsTrue(results > 0);

        }
    }

}
