using DMD.BL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DMD.BL.Test
{
    [TestClass]
    public class StatModifierManagerTests
    {
        //Test the ability to load data.
        [TestMethod]
        public void LoadTest()
        {
            //Run Async Task for Loading.
            Task.Run(async () =>
            {
                var task = await StatModifierManager.Load();
                List<Models.StatModifier> statModifiers = task;
                Assert.AreEqual(3, statModifiers.ToList().Count);
            }).GetAwaiter().GetResult();
        }

        /*
        //This test method is used to test inserting data into the corresponding table and manager //ALTER COMMENTS TO SAY SPECIFIC ONES LATER.
        [TestMethod]
        public async Task InsertTest()
        {

            IEnumerable<StatModifier> statModifierList = await StatModifier.Load();
            if (statModifierList.Any())
            {
                StatModifier statModifier = new StatModifier()
                {
                    Value = 300,
                    Modifier = 300,
                };

                int result = await StatModifierManager.Insert(statModifier, true);
                Assert.IsTrue(result == 1);
            }
        }
        */
        
    }
}
