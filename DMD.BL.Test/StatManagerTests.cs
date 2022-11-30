using DMD.BL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DMD.BL.Test
{
    [TestClass]
    public class StatManagerTests
    {
        //Test the ability to load data.
        [TestMethod]
        public async Task LoadTest()
        {
            //Run Async Task for Loading.
            Task.Run(async () =>
            {
                var task = await StatManager.Load();
                List<Models.Stat> stats = task;
                Assert.AreEqual(3, stats.ToList().Count);
            }).GetAwaiter().GetResult();
        }

        /*
        //This test method is used to test inserting data into the corresponding table and manager //ALTER COMMENTS TO SAY SPECIFIC ONES LATER.
        [TestMethod]
        public async Task InsertTest()
        {

            IEnumerable<Stat> statList = await StatManager.Load();
            if (statList.Any())
            {
                Stat stat = new Stat()
                {
                    Id = Guid.NewGuid(),
                    Name = "Charisma Bobby",
                    Description = "TEST this stat calculates how much charisma bobby has",
                    Value = 300,
                };

                int result = await StatManager.Insert(stat, true);
                Assert.IsTrue(result == 1);
            }
        }
        */
    }
}
