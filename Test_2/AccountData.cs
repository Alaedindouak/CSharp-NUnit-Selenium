using System;

namespace Test_1
{
    public class AccountData
    {
        public string Email { get; set; }
        public string Password { get; set; }

        public AccountData(string email, string password)
        {
            this.Email = email;
            this.Password = password;
        }
    }
}