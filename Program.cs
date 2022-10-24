using System;
using System.Collections.Generic;
using System.Text;

namespace PasswordChecker
{

    public class Tools
    {
        public Tools()
        {

        }

        public static bool Contains(string target, string list)
        {
            return target.IndexOfAny(list.ToCharArray()) != -1;
        }

        public static void ContainsTest()
        {
            string loudWord = "LASDAD";
            string quietWord = "pssst";
            string mixedWord = "lkaAWEkasfkEW";

            string uppercase = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            string lowercase = "abcdefghijklmnopqrstuvwxyz";

            Console.WriteLine("Running \"tests...\"");
            Console.WriteLine($"Should be true: {Contains(loudWord, uppercase)}");
            Console.WriteLine($"Should be false: {Contains(loudWord, lowercase)}");
            Console.WriteLine($"Should be false: {Contains(quietWord, uppercase)}");
            Console.WriteLine($"Should be true: {Contains(quietWord, lowercase)}");
            Console.WriteLine($"Should be true: {Contains(mixedWord, uppercase)}");
            Console.WriteLine($"Should be true: {Contains(mixedWord, lowercase)}");
        }

        class Program
        {
            static void Main(string[] args)
            {
                int check;
                int minLength = 8;
                string uppercase = "ABCDEFGHIJKLMNOPQRSTVUWXYZ";
                string lowercase = "abcdefghijklmnopqrstvuwxyz";
                string digits = "0123456789";
                string specialChars = "!?@#$%^&*";

                Console.WriteLine("Enter your password");
                string password = Console.ReadLine();
                int password_length = password.Length;

                if (password_length >= minLength)
                {
                    check++;
                }

                if (Tools.Contains(password, uppercase))
                {
                    check++;
                }
                if (Tools.Contains(password, lowercase))
                {
                    check++;
                }
                if (Tools.Contains(password, digits))
                {
                    check++;
                }
                if (Tools.Contains(password, specialChars))
                {
                    check++;
                }

                switch (check)
                {
                    case 1:
                        Console.WriteLine("Password is weak");
                        break;

                    case 2:
                        Console.WriteLine("Password is medium");
                        break;

                    case 3:
                        Console.WriteLine("Password is Strong");
                        break;

                    case 4:
                    case 5:
                        Console.WriteLine("Password is extremely strong");
                        break;

                    default:
                        Console.WriteLine("The password doesn’t meet any of the standards");
                        break;
                }

            }
        }
    }

}
