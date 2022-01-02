using NUnit.Framework;

namespace Test_2_HW
{
    [TestFixture]
    public class Test : TestBase
    {
        [Test]
        public void Test_1()
        {
            AccountData user = new("github@email.com", "password");
            
            OpenHomepage();
            Login(user);
        }

        [Test]
        public void Test_2()
        {
            CreatePost();
        }
    }
}
