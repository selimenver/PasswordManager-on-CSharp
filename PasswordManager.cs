using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<string> Passwords = new List<string>();

        while (true)
        {
            Console.WriteLine("Welcome to password manager.");
            Console.WriteLine("Type 1 to add a password");
            Console.WriteLine("Type 2 to view saved passwords.");
            Console.WriteLine("Type 3 to exit.");

            char choice = Convert.ToChar(Console.ReadLine());
            Console.Clear();

            if (choice == '1')
            {
                Console.Clear();
                Console.WriteLine("Enter the password");
                string PassAdder = Console.ReadLine();
                Console.Clear();
                Console.WriteLine("Enter the purpose of the password ex: discord password");
                string Purpose = Console.ReadLine();
                Passwords.Add(PassAdder + "-" + Purpose);
                Console.Clear();
                Console.WriteLine("Added to your saved passwords.");
            }
            else if (choice == '2')
            {
                Console.Clear();
                if (Passwords.Count == 0)
                {
                    Console.WriteLine("No passwords saved yet.");
                }
                else
                {
                    Console.WriteLine("Your passwords:");
                    foreach (string Password in Passwords)
                    {
                        Console.WriteLine(Password);
                    }
                    Console.WriteLine();
                }
            }
            else if (choice == '3')
            {
                Console.Clear();
                break;
            }
            else
            {
                Console.Clear();
                Console.WriteLine("Enter a valid choice.");
            }
        }
    }
}
