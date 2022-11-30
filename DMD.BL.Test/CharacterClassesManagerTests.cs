using DMD.BL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DMD.BL.Test
{
    [TestClass]
    public class CharacterClassesManagerTests
    {
        /*
        //Test the ability to load data.
        [TestMethod]
        public void LoadTest()
        {
            //Run Async Task for Loading.
            Task.Run(async () =>
            {
                var task = await CharacterClassesManager.Load();
                List<Models.CharacterClass> charClasses = task;
                Assert.AreEqual(3, charClasses.ToList().Count);
            }).GetAwaiter().GetResult();
        }



        //This test method is used to test inserting data into the corresponding table and manager //ALTER COMMENTS TO SAY SPECIFIC ONES LATER.
        [TestMethod]
        public async Task InsertTest()
        {

            IEnumerable<CharacterClass> charClassList = await CharacterClassesManager.Load();
            if (charClassList.Any())
            {
                CharacterClass charClass = new CharacterClass()
                {
                    Id = Guid.NewGuid(),
                    Character_Id = charClassList.First().Character_Id,
                    Class_Id = charClassList.First().Class_Id,
                    Class_Level = 3,
                };

                int result = await CharacterClassesManager.Insert(charClass, true);
                Assert.IsTrue(result == 1);
            }
        }
        */
    }
}
