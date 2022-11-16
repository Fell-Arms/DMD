using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DMD.BL.Models;

namespace DMD.BL.Test
{
    [TestClass]
    public class CharacterManagerTests
    {

        //Test the ability to load data in CharacterManager
        [TestMethod]
        public void LoadTest()
        {
            //Run Async Task for Loading.
            Task.Run(async () =>
            {
                var task = await CharacterManager.Load();
                IEnumerable<Models.Character> characters = task;
                Assert.AreEqual(3, characters.ToList().Count);
            }).GetAwaiter().GetResult();


            //Run Async Task for Loading in CharacterArmor
            Task.Run(async () =>
            {
                var task = await CharacterManager.Load();
                IEnumerable<Models.CharacterArmor> characterArmors = task;
                Assert.AreEqual(3, characterArmors.ToList().Count);
            }).GetAwaiter().GetResult();

        }


    }
}
