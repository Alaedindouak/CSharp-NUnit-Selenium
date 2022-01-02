using NUnit.Framework;
using Test_1;
using Test_3.Models;

namespace Test_3
{
    public class LoginTest : TestBase
    {
        [Test]
        public void Test1()
        {
            AccountData user = new AccountData("github@email.com", "password");
            
            app.Navigation.OpenPageHome();
            app.Auth.Login(user);
        }
    }
}
