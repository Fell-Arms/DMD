using DMD.BL.Models;
using DMD.PL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DMD.BL.Test
{
    [TestClass]
    public class CharacterSpellChargesManagerTests
    {
        /*
        //Test the ability to load data.
        [TestMethod]
        public void LoadTest()
        {
            //Run Async Task for Loading.
            Task.Run(async () =>
            {
                var task = await CharacterSpellChargesManager.Load();
                List<Models.CharacterSpellCharge> characterSpellCharges = task;
                Assert.AreEqual(3, characterSpellCharges.ToList().Count);
            }).GetAwaiter().GetResult();
        }


        //NEEDS TO BE MAJORLY FIXED UP
        //This test method is used to test inserting data into the corresponding table and manager //ALTER COMMENTS TO SAY SPECIFIC ONES LATER.
        [TestMethod]
        public async Task InsertTest()
        {

            IEnumerable<CharacterSpellCharge> charSpellChargeList = await CharacterSpellChargesManager.Load();
            if (charSpellChargeList.Any())
            {
                CharacterSpellCharge charSpellCharge = new CharacterSpellCharge()
                {
                    Id = Guid.NewGuid(),
                    Character_Id = charSpellChargeList.First().Character_Id,
                    Spell_Charges_By_Level_Id = charSpellChargeList.First().Spell_Charges_By_Level_Id,
                    ChargesAvailable = 300,
                };

                int result = await CharacterSpellChargesManager.Insert(charSpellCharge, true);
                Assert.IsTrue(result == 1);
            }
        }
        */
    }
}
