using System;

namespace Task_Accaunt_OOP
{
    class Program
    {
        static void Main(string[] args)
        {
            User user = new User
            {
                FullName = "User1",
                Email = "user1@email.com"
            };

            user.ShowInfo();
            if (user.PasswordChecker("UserOnePass"))
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\nYour password is valid! \nYour account created successfully");
                Console.ResetColor();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\nYour password is not valid!");
                Console.ResetColor();
            }
        }
    }

    abstract class Account
    {
        public abstract bool PasswordChecker(string password);
        public virtual void ShowInfo() { }
    }

    class User : Account
    {
        public string FullName { get; set; }
        public string Email { get; set; }
        public string Password
        {
            set
            {
                if (this.PasswordChecker(value))
                {
                    this.Password = value;
                }
            }
            get
            {
                return this.Password;
            }
        }
        public override bool PasswordChecker(string password)
        {
            if (string.IsNullOrEmpty(password) == true || password.Length < 8 || password.ToUpper() == password || password.ToLower() == password)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public override void ShowInfo()
        {
            Console.WriteLine($"User full name is {this.FullName} \nUser email is {this.Email}");
        }
    }
}
