namespace _01.Persons
{
    using System;
    using System.Text.RegularExpressions;

    public class Validation
    {
        private const string NameRegex = @"^[A-Z][a-zA-Z- ]+$";
        private const int MinAge = 1;
        private const int MaxAge = 100;
        private const string EmailRegex = @"^[a-z0-9!#$%&'*+\/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+\/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?$";

        public static bool IsName(string name)
        {
            var nameMatcher = new Regex(NameRegex);
            return nameMatcher.IsMatch(name);
        }

        public static bool IsAge(int age)
        {
            return age >= MinAge && age <= MaxAge;
        }

        public static bool IsEmail(string email)
        {
            if (!string.IsNullOrEmpty(email))
            {
                var emailMatcher = new Regex(EmailRegex);
                return emailMatcher.IsMatch(email);
            }
            else
            {
                return false;
            }
        }
    }
}
