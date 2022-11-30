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
    public class CharacterSkillProficiencyManagerTests
    {
        /*
        //Test the ability to load data.
        [TestMethod]
        public async Task LoadTest()
        {
            //Run Async Task for Loading.
            Task.Run(async () =>
            {
                var task = await CharacterSkillProficiencyManager.Load();
                List<Models.CharacterSkill> characterSkills = task;
                Assert.AreEqual(3, characterSkills.ToList().Count);
            }).GetAwaiter().GetResult();
        }


        //NEEDS TO BE MAJORLY FIXED UP
        //This test method is used to test inserting data into the corresponding table and manager //ALTER COMMENTS TO SAY SPECIFIC ONES LATER.
        [TestMethod]
        public async Task InsertTest()
        {

            IEnumerable<tblCharacterSkillProficiency> charSkillProficiency = await CharacterSkillProficiencyManager.Load();
            if (charSkillProficiency.Any())
            {
                CharacterSkill charSkill = new CharacterSkill()
                {
                    Id = Guid.NewGuid(),
                    Character_Id = charSkillProficiency.First().Character_Id,
                    Skill_Id = charSkillProficiency.First().Skill_Id
                };

                int result = await CharacterSkillProficiencyManager.Insert(charSkillProficiency, true);
                Assert.IsTrue(result == 1);
            }
        }
        */
    }
}
