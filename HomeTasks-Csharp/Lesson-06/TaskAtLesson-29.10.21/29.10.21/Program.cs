using System;
using System.Collections.Generic;
using System.Linq;

namespace _29._10._21
{
    class Program
    {
        static void Main(string[] args)
        {
            PhoneBook bestFriend = new PhoneBook();

            Console.WriteLine("How many new contact you wanna add?");
            var contactLimit = Convert.ToInt16(Console.ReadLine());

            for (int i = 0; i < contactLimit; i++)
            {
                Console.WriteLine("Enter contact name to add:");
                string contactName = Console.ReadLine();
                Console.WriteLine("Enter contact number to add:");
                string contactNumber = Console.ReadLine();
                bestFriend.AddPerson(contactName, contactNumber);
            }
            Console.WriteLine("Enter name to search: ");
            string searchName = Console.ReadLine();
            bestFriend.SearchPersonByName(searchName);

            Console.WriteLine("Enter number to search: ");
            string searcNumber = Console.ReadLine();
            bestFriend.SearchPersonByNumber(searcNumber);

            Console.WriteLine("Enter name to delete: ");
            string deleteName = Console.ReadLine();
            bestFriend.DeleteByName(deleteName);

            Console.WriteLine("Enter number to delete: ");
            string deleteNumber = Console.ReadLine();
            bestFriend.DeleteByNumber(deleteNumber);
        }
    }
    class PhoneBook
    {
        private readonly Dictionary<string, string> _phoneBook = new Dictionary<string, string>();

        //public PhoneBook()
        //{
        //    _phoneBook = new Dictionary<string, string>();   #this is better method
        //}

        public void AddPerson(string name, string number)
        {
            if (_phoneBook.ContainsKey(name))
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"{name} is exist");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine($"Select option: \n 1.Keep the number \n 2.Update");
                string option = Console.ReadLine();
                while (option != "1" && option != "2")
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine($"Pls  select correct option");
                    Console.ForegroundColor = ConsoleColor.White;
                    option = Console.ReadLine();
                }
                if (option == "2")
                {
                    _phoneBook[name] = number;
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine($"{number} successfully updated");
                    Console.ForegroundColor = ConsoleColor.White;
                }
            }
            else
            {
                _phoneBook.Add(name, number);
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"{name} with {number} added");
                Console.ForegroundColor = ConsoleColor.White;
            }
        }
        public void SearchPersonByName(string name)
        {
            if (_phoneBook.ContainsKey(name))
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine($"{name} number is {_phoneBook[name]}");
                Console.ForegroundColor = ConsoleColor.White;
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("There is no such contact");
                Console.ForegroundColor = ConsoleColor.White;
            }
        }
        public void SearchPersonByNumber(string number)
        {
            if (_phoneBook.ContainsValue(number))
            {
                foreach (var item in _phoneBook.Keys)
                {
                    if (_phoneBook[item] == number)
                    {
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine($"This {number} belong to {item}");
                        Console.ForegroundColor = ConsoleColor.White;
                    }
                }
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("There is no such contact");
                Console.ForegroundColor = ConsoleColor.White;
            }
        }
        public void DeleteByName(string name)
        {
            if (_phoneBook.ContainsKey(name))
            {
                _phoneBook.Remove(name);

                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.WriteLine("Contacts:");
                foreach (var item in _phoneBook)
                {
                    Console.WriteLine(item);
                }
                Console.ForegroundColor = ConsoleColor.White;
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("There is no such contact");
                Console.ForegroundColor = ConsoleColor.White;
            }
        }

        public void DeleteByNumber(string number)
        {
            foreach (var item in _phoneBook.Where(kvp => kvp.Value == number).ToList())
            {
                _phoneBook.Remove(item.Key);

                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.WriteLine("Contacts:");
                Console.ForegroundColor = ConsoleColor.White;
                foreach (var item1 in _phoneBook)
                {
                    Console.WriteLine(item1);
                }
            }
            //else
            //{
            //    Console.ForegroundColor = ConsoleColor.Red;
            //    Console.WriteLine("There is no such contact");
            //    Console.ForegroundColor = ConsoleColor.White;
            //}
        }
    }
}