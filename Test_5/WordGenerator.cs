using System;

namespace Test_5
{
    public class WordGenerator
    {
        public static string RandomWordGenerator(int length)
        {            
            Random random = new Random();
            string randomString = String.Empty;
            char[] letters = "qwertyuiopasdfghjklmzxcvbn".ToCharArray();
        
            for (int i = 0; i < length; i++)
            {
                randomString += letters[random.Next(0, letters.Length)].ToString();
            }
            
            return randomString;
        }
    }
}