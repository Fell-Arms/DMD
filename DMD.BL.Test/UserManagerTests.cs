using DMD.BL.Models;

namespace DMD.BL.Test
{
    [TestClass]
    public class UserManagerTests
    {

        //Test the ability to load data.
        [TestMethod]
        public async Task LoadTest()
        {
            IEnumerable<User> users = await UserManager.Load();
            Assert.IsTrue(0 < users.Count());
        }

        //Test The Update Function
        [TestMethod]
        public async Task UpdateTest()
        {
            IEnumerable<User> users = await UserManager.Load();     //Create a load method.
            User user = users.First();
            user.UserName = "Test1";

            int results = UserManager.Update(user, true);
            Assert.AreEqual(1, results);
        }

        //Test The Delete Function
        [TestMethod]
        public async Task DeleteTest()
        {
            IEnumerable<User> users = await UserManager.Load();     //Create a load method.
            User user = users.First();

            int results = UserManager.Delete(user.Id, true);
            Assert.AreEqual(1, results);
        }
    }
}