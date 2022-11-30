using DMD.BL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DMD.BL.Test
{
    [TestClass]
    public class ClassManagerTests
    {
        //Test the ability to load data.
        [TestMethod]
        public async Task LoadTest()
        {
            //Run Async Task for Loading.
            Task.Run(async () =>
            {
                var task = await ClassesManager.Load();
                List<Models.Class> classes = task;
                Assert.AreEqual(3, classes.ToList().Count);
            }).GetAwaiter().GetResult();
        }

        /*
        //This test method is used to test inserting data into the corresponding table and manager //ALTER COMMENTS TO SAY SPECIFIC ONES LATER.
        [TestMethod]
        public async Task InsertTest()
        {

            IEnumerable<Class> classList = await ClassesManager.Load();
            if (classList.Any())
            {
                Class classInstance = new Class() //naming the instance only "class" throws an error for some reason.
                {
                    Id = Guid.NewGuid(),
                    Name = "Bobbathin",
                    Description = "TEST Bobbathin is the bobbiest of all bobbathins",
                    HPUpDieOnLevel = 3,
                };

                int result = await ClassesManager.Insert(classInstance, true);
                Assert.IsTrue(result == 1);
            }
        }
        */
    }
}
