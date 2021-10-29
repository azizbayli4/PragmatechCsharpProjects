using System;
using System.Collections.Generic;

namespace CountriesAndCapitalCitiesTask
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> capitals = new Dictionary<string, string>();
            string country;
            string capital;
            bool check1 = true;

            //Console.WriteLine("How many capital you want to add?: ");
            //byte lim = Convert.ToByte(Console.ReadLine());

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Please, enter country name: ");
                country = Console.ReadLine();
                Console.WriteLine("Please, enter the capital of the country: ");
                capital = Console.ReadLine();

                capitals.Add(country, capital);
            }


            while (check1)
            {
                Console.WriteLine("\nEnter country name to find the capital of it: \nTo print all list enter 'all'");
                string countryName = Console.ReadLine();
                if (countryName == "all")
                {
                    foreach (var item in capitals)
                    {
                        Console.WriteLine($"\nThe capital of {item.Key} is {item.Value}");
                    }
                }
                else if (capitals.ContainsKey(countryName))
                {
                    Console.WriteLine($"\nThe capital of {countryName} is {capitals[countryName]}");
                }
                else
                {
                    Console.WriteLine("\nCountry you entered is not in the list");
                }
                while (true)
                {
                    Console.WriteLine("\nWould you like to continue (y/n):");
                    string choice = Console.ReadLine();
                    if (choice == "n")
                    {
                        Console.WriteLine("Thanks!");
                        check1 = false;
                        break;
                    }
                    else if (choice == "y")
                    {
                        break;
                    }
                    else
                    {
                        Console.WriteLine("\nPlease enter 'y' or 'n' ");
                    }
                }
            }
        }
    }
}
