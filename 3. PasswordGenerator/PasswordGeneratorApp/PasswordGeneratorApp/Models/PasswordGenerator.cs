using System;
using System.Text;

namespace PasswordGeneratorApp.Models
{
    public class PasswordGenerator
    {
        public int Length { get; set; } = 12;
        public bool IncludeUppercase { get; set; } = true;
        public bool IncludeLowercase { get; set; } = true;
        public bool IncludeNumbers { get; set; } = true;
        public bool IncludeSpecialChars { get; set; } = true;
        public string? GeneratedPassword { get; set; }

        public void GeneratePassword()
        {
            const string uppercaseChars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            const string lowercaseChars = "abcdefghijklmnopqrstuvwxyz";
            const string numberChars = "0123456789";
            const string specialChars = "!@#$%^&*()-_=+<>?";

            var charPool = new StringBuilder();

            if (IncludeUppercase)
                charPool.Append(uppercaseChars);

            if (IncludeLowercase)
                charPool.Append(lowercaseChars);

            if (IncludeNumbers)
                charPool.Append(numberChars);

            if (IncludeSpecialChars)
                charPool.Append(specialChars);

            if (charPool.Length == 0)
            {
                GeneratedPassword = string.Empty;
                return;
            }

            var password = new StringBuilder();
            var random = new Random();

            for (int i = 0; i < Length; i++)
            {
                var index = random.Next(charPool.Length);
                password.Append(charPool[index]);
            }

            GeneratedPassword = password.ToString();
        }
    }

}


