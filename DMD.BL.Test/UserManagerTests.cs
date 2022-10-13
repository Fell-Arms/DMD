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
            Assert.AreEqual(3, users.Count);
        }

        //Test The Update Function
        [TestMethod]
        public void UpdateTest()
        {
            List<User> users = UserManager.Load();     //Create a load method.
            User user = users[0];
            user.UserName = "Test1";

            int results = UserManager.Update(user, true);
            Assert.AreEqual(1, results);
        }

        //Test The Delete Function
        [TestMethod]
        public void DeleteTest()
        {
            List<User> users = UserManager.Load();     //Create a load method.
            User user = users[0];

            int results = UserManager.Delete(user.Id, true);
            Assert.AreEqual(1, results);
        }
    }
}