using System;
using System.Collections.Generic;
using System.Text;

namespace BasicSelenium
{
   public static class TestData
    {

        public static string FirstName = "Silviya";
        public static string SirName = "Slavcheva";
        public static string Email = RandomEmailGenerator();
        public static string Password = "aaaaaa";
        public static string Country = "BG";
        public static string City = "Sofia";

       static string RandomEmailGenerator()
        {
            Random randomGenerator = new Random();
            int randomInt = randomGenerator.Next(1000);
            return "username" + randomInt + "@gmail.com";
        }

    }
}
