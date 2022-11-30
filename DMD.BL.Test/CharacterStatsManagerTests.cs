using DMD.BL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DMD.BL.Test
{
    [TestClass]
    public class CharacterStatsManagerTests
    {
        //Test the ability to load data.
        [TestMethod]
        public void LoadTest()
        {
            //Run Async Task for Loading.
            Task.Run(async () =>
            {
                var task = await CharacterStatsManager.Load();
                List<Models.CharacterStat> characterStats = task;
                Assert.AreEqual(3, characterStats.ToList().Count);
            }).GetAwaiter().GetResult();
        }


        //NEEDS TO BE MAJORLY FIXED UP
        //This test method is used to test inserting data into the corresponding table and manager //ALTER COMMENTS TO SAY SPECIFIC ONES LATER.
        [TestMethod]
        public async Task InsertTest()
        {

            IEnumerable<CharacterStat> charStatList = await CharacterStatsManager.Load();
            if (charStatList.Any())
            {
                CharacterStat charStat = new CharacterStat()
                {
                    Id = Guid.NewGuid(),
                    Character_Id = charStatList.First().Character_Id,
                    Stat_Id = charStatList.First().Stat_Id,
                    Value = 300,
                };

                int result = await CharacterStatsManager.Insert(charStat, true);
                Assert.IsTrue(result == 1);
            }
        }

    }
}
