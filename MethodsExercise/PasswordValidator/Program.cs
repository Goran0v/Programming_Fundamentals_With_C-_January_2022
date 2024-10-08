﻿using System;

namespace PasswordValidator
{
    class Program
    {
        static void Main(string[] args)
        {
            const int passwordMinLength = 6;
            const int passwordMaxLength = 10;
            const int passwordDigitsMinCount = 2;
            string password = Console.ReadLine();
            bool isPasswordValid = ValidatePassword(password, passwordMinLength, passwordMaxLength, passwordDigitsMinCount);

            if (isPasswordValid)
            {
                Console.WriteLine("Password is valid");
            }
        }
        static bool ValidatePassword(string password, int passwordMinLength, int passwordMaxLength, int passwordDigitsMinCount)
        {
            bool isPasswordValid = true;
            if (!ValidatePasswordLength(password, passwordMinLength, passwordMaxLength))
            {
                Console.WriteLine($"Password must be between {passwordMinLength} and {passwordMaxLength} characters");
                isPasswordValid = false;
            }
            if (!ValidatePasswordIsAlphaAndDigit(password))
            {
                Console.WriteLine($"Password must consist only of letters and digits");
                isPasswordValid = false;
            }
            if (!ValidatePasswordAtleastTwoDigits(password, passwordDigitsMinCount))
            {
                Console.WriteLine($"Password must have at least {passwordDigitsMinCount} digits");
                isPasswordValid = false;
            }

            return isPasswordValid;
        }
        static bool ValidatePasswordLength(string password, int minLength, int maxLength)
        {
            if (password.Length >= minLength && password.Length <= maxLength)
            {
                return true;
            }

            return false;
        }
        static bool ValidatePasswordIsAlphaAndDigit(string password)
        {
            foreach (char ch in password)
            {
                if (!Char.IsLetterOrDigit(ch))
                {
                    return false;
                }
            }

            return true;
        }
        static bool ValidatePasswordAtleastTwoDigits(string password, int minDigits)
        {
            int counter = 0;
            foreach (char ch in password)
            {
                if (Char.IsDigit(ch))
                {
                    counter++;
                }
            }

            return counter >= minDigits;
        }
    }
}
