using System;
using System.Text;


namespace CreateAccountAndCheck
{
    class Program
    {
        static bool IsUserNameValid(string str)
        {
            {
                foreach (char c in str)
                {
                    if (!Char.IsLetterOrDigit(c))
                        return false;
                }
                return true;
            }
        }

        static bool IsPassWordvalid(string s)
        {
            if (s.Length >= 8 && s.Length <= 25)
            {
                byte[] ASCIIvalues = Encoding.ASCII.GetBytes(s);
                foreach (var item in ASCIIvalues)
                {
                    if (item > 47 && item < 58
                        || item > 64 && item < 91
                        || item > 97 && item < 123
                        || item > 32 && item < 48
                        || item > 58 && item < 65)
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Create an account:");
            Console.WriteLine("\nPlease enter User Name(Use only letters and  digits!):");
            string userName = Console.ReadLine();
            Console.WriteLine("\nPlease enter Password: ");
            string userPassword = Console.ReadLine();
            if (IsUserNameValid(userName) && IsPassWordvalid(userPassword))
            {
                Account account = new Account(userName, userPassword);
                Console.WriteLine($"\n\nCongrats,you created {account.No} numbered account. Welcome {account.userName}!");
            }
            else
            {
                Console.WriteLine("You entered invalid data! Please, try again");
            }
        }
    }

    class Account
    {
        public string userName;
        public string password;
        public static int num;
        public int No;

        public Account(string userName,string password)
        {
            this.userName = userName;
            this.password = password;
            this.No = num++;
        }
    }
}
