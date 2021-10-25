using System;
using System.Text;
using System.Linq;



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
                    {
                        Console.WriteLine("\nEntered invalid User Name");
                        return false;
                    }
                }
                return true;
            }
        }


        public static byte IsPassWordvalid(string password)
        {
            bool Uppercase = password.Any(char.IsUpper);
            bool Lowercase = password.Any(char.IsLower);
            bool SpecialChar = password.Any(ch => !Char.IsLetterOrDigit(ch));
            bool Digit = password.Any(char.IsDigit);

            byte score = 0;

            if (password.Length >= 8 && password.Length <= 25)
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

            return score;
        }



        //static bool IsPassWordvalid(string s)
        //{
        //    if (s.Length >= 8 && s.Length <= 25)
        //    {
        //        byte[] ASCIIvalues = Encoding.ASCII.GetBytes(s);
        //        foreach (var item in ASCIIvalues)
        //        {
        //            if (item > 47 && item < 58
        //                || item > 64 && item < 91
        //                || item > 97 && item < 123
        //                || item > 32 && item < 48
        //                || item > 58 && item < 65)
        //            {
        //                return true;
        //            }
        //        }
        //    }
        //    return false;
        //}

        static void Main(string[] args)
        {
            Console.WriteLine("Create an account:");
            Console.WriteLine("\nPlease enter User Name(Use only letters and  digits!):");
            string userName = Console.ReadLine();
            Console.WriteLine("\nPlease enter Password: ");
            string userPassword = Console.ReadLine();
            if (IsUserNameValid(userName) && IsPassWordvalid(userPassword)==5)
            {
                Account account = new Account(userName, userPassword);
                Console.WriteLine($"\n\nCongrats,you created {account.No} numbered account. Welcome {account.userName}!");
            }
            //else
            //{
            //    Console.WriteLine("You entered invalid data! Please, try again");
            //}
        }
    }

    class Account
    {
        public string userName;
        public string password;
        public static int num=1;
        public int No;

        public Account(string userName,string password)
        {
            this.userName = userName;
            this.password = password;
            this.No = num++;
        }
    }
}
