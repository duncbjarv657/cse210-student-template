using System;
using System.Collections.Generic;

namespace BreathingMenu
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                // menu ;)
                Console.WriteLine("Choose an activity:");
                Console.WriteLine("1. Breathing activity");
                Console.WriteLine("2. Listing activity");
                Console.WriteLine("3. Reflection activity");
                Console.WriteLine("4. Exit");
                Console.Write("Enter your choice (1-4): ");

                string userInput = Console.ReadLine();

                switch (userInput)
                {
                    case "1":
                        DoBreathingActivity.Breathe();
                        break;
                    case "2":
                        DoListingActivity.Start();
                        break;
                    case "3":
                        DoReflectionActivity.Reflect();
                        break;
                    case "4":
                        return;
                    default:
                        Console.WriteLine("Invalid input. Please enter a number from 1-4.");
                        break;
                }

                Console.WriteLine();
            }
        }
    }
};