using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;


namespace OOP
{
    class Program
    {
        static void Main(string[] args)
        {
            User.PasswordChecker();
            User.ShowInfo();
        }
    }

    abstract class Account
    {
        public void PasswordChecker()
        {
            Console.WriteLine("");
        }
        public virtual void ShowInfo()
        {
            Console.WriteLine("");
        }
    }

    class User : Account
    {
        public string fullname { get; set; }
        private string password { get; set; }

        private string _email;
        public string email
        {
            get { return _email; }
            set
            {
                try
                {
                    MailAddress mailAddress = new MailAddress(value);
                    _email = value;
                }
                catch (Exception)
                {
                    Console.WriteLine("\nEMAIL IS NOT VALID");
                }
            }

        }

        public User(string fullname, string email, string password)
        {
            this.fullname = fullname;
            this.email = email;
            this.password = password;
        }
        public static List<User> user = new List<User>();

        public static void PasswordChecker()
        {
            foreach (var item in user)
            {
                bool Uppercase = item.password.Any(char.IsUpper);
                bool Lowercase = item.password.Any(char.IsLower);
                bool SpecialChar = item.password.Any(ch => !Char.IsLetterOrDigit(ch));
                bool Digit = item.password.Any(char.IsDigit);

                byte score = 0;

                if (item.password.Length >= 8)
                {
                    score++;
                    Console.WriteLine("\nMinimum Length test passed.");
                }
                else
                {
                    Console.WriteLine("Minimum Length test failed.");
                }

                if (Uppercase)
                {
                    score++;
                    Console.WriteLine("Uppercase test passed.");
                }
                else
                {
                    Console.WriteLine("Uppercase test failed.");
                }

                if (Lowercase)
                {
                    score++;
                    Console.WriteLine("Lowercase test passed.");
                }
                else
                {
                    Console.WriteLine("Lowercase test failed.");
                }

                if (Digit)
                {
                    score++;
                    Console.WriteLine("Digits test passed.");
                }
                else
                {
                    Console.WriteLine("Digits test failed.");
                }

                if (SpecialChar)
                {
                    score++;
                    Console.WriteLine("Special Characters test passed.");
                }
                else
                {
                    Console.WriteLine("Special Characters test failed.");
                }

            }
        }
        public static void ShowInfo()
        {
            Console.WriteLine("Enter Full name: ");
            string fullname = Console.ReadLine();

            Console.WriteLine("\nEnter email: ");
            string email = Console.ReadLine();

            Console.WriteLine("\nEnter password: ");
            string password = Console.ReadLine();

            user.Add(new User(fullname, email, password));

            foreach (var item in user)
            {
                Console.WriteLine($"\nFullName:{item.fullname} email:{item.email}");
            }
        }
    }
}
