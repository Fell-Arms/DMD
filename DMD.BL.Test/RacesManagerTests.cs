using DMD.BL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DMD.BL.Test
{
    [TestClass]
    public class RacesManagerTests
    {
        //Test the ability to load data.
        [TestMethod]
        public async Task LoadTest()
        {
            //Run Async Task for Loading.
            Task.Run(async () =>
            {
                var task = await RacesManager.Load();
                List<Models.Race> races = task;
                Assert.AreEqual(3, races.ToList().Count);
            }).GetAwaiter().GetResult();
        }

        /*
        //This test method is used to test inserting data into the corresponding table and manager //ALTER COMMENTS TO SAY SPECIFIC ONES LATER.
        [TestMethod]
        public async Task InsertTest()
        {

            IEnumerable<Race> raceList = await RacesManager.Load();
            if (raceList.Any())
            {
                Race race = new Race()
                {
                    Id = Guid.NewGuid(),
                    Name = "Bobby Race",
                    Description = "TEST This is the bobbiest of all races",
                };

                int result = await RacesManager.Insert(race, true);
                Assert.IsTrue(result == 1);
            }
        }
        */
        
    }
}
