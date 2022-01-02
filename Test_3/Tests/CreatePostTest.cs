using NUnit.Framework;
using Test_1;
using Test_3.Models;

namespace Test_3
{
    public class CreatePostTest : TestBase
    {
        [Test]
        public void Test1()
        {
            AccountData user = new AccountData("github@email.com", "password");
            PostData post = new PostData("Testing", "testing", "test");
            
            app.Navigation.OpenPageHome();
            app.Auth.Login(user);
            app.Navigation.OpenDashboard();
            app.AccountHelper.CreatePost(post);
        }
    }
}
