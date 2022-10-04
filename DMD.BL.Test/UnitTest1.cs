using DMD.BL.Models;

namespace DMD.BL.Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod()]
        public void InsertTest()
        {
            User user = new User();
            user.FirstName = "Clark";
            user.LastName = "Kent";
            user.UserName = "ckent";
            user.Email = "test@gmail.com";
            user.Password = "maple";
            int actual = UserManager.Insert(user, true);
            Assert.AreEqual(1, actual);
        }

        [TestMethod]
        public void SeedTest()
        {
            UserManager.Seed();
        }


        [TestMethod]
        public void LoginSuccededTest()
        {
            UserManager.Seed();
            Assert.IsTrue(UserManager.Login(new User { UserName = "bfoote", Password = "maple" }));
            UserManager.DeleteAll();
        }

        [TestMethod]
        public void LoginFailedTest()
        {
            try
            {
                UserManager.Seed();
                UserManager.Login(new User { UserName = "bfoote", Password = "dude" });

            }
            catch (LoginFailureException)
            {
                Assert.IsTrue(true);
            }
            catch (Exception)
            {
                Assert.Fail();
            }
            UserManager.DeleteAll();
        }
    }
}