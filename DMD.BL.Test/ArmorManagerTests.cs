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
    }
}
