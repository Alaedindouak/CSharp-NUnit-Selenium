using NUnit.Framework;
using Test_4.Models;

namespace Test_4
{
    [Order(1)]
    public class AuthTest : TestBase
    {
        [Test]
        public void LoginTesting()
        {
            string email = "github@email.com";
            string password = "password";

            AccountData account = new AccountData(email, password);
            app.Login.Login(account);
        }
    }
}
