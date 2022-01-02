namespace Test_4.Models
{
    public class AccountData
    {
        public string Email { get; set; }
        public string Password { get; set; }

        public AccountData(string email, string password)
        {
            Email = email;
            Password = password;
        }
    }
}