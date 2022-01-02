using NUnit.Framework;

namespace Test_1
{
    [TestFixture]
    public class Test : TestBase
    {  
        
        [Test]
        public void Test_1()
        {
            Login(new AccountData("github@email.com", "password"));
        }

        [Test]
        public void Test_2()
        {
            PostData post = new PostData("testing", "testing", "testing");
            
            Login(new AccountData("github@email.com", "password"));
            OpenDashboard();
            CreatePost(post);
        }
    }
}
