using DMD.BL.Models;

namespace DMD.BL.Test
{
    [TestClass]
    public class UserManagerTests
    {

        //Test the ability to load data.
        [TestMethod]
        public void LoadTest()
        {
            List<User> users = UserManager.Load();
            Assert.AreEqual(2, users.Count);
        }


        //Adjust to properly test delete function.
        
        [TestMethod]
        public void DeleteTest()
        {
            List<User> user = UserManager.Load();     //Create a load method.

            int results = UserManager.Delete(user.Id, true);
            Assert.AreEqual(1, results);
        }
    }
}