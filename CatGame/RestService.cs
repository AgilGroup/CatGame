using System;

namespace CatGame
{
    internal class RestService
    {
        public static void ShowRestMenu(Cat player)
        {
            bool resting = true;

            while (resting)
            {
                Console.Clear();

                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("=== Rest Menu ===\n");
                Console.ResetColor();

                Console.WriteLine("[1] Rest and recover health");
                Console.WriteLine("[2] Return to main menu");

                Console.Write("\nChoose an option: ");
                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        Console.WriteLine($"\n{player.Name} rests peacefully...");

                        player.Heal();

                        Console.WriteLine($"\nCurrent HP: {player.Health}/{player.MaxHealth}");

                        Console.WriteLine("\nPress any key to continue...");
                        Console.ReadKey();
                        break;

                    case "2":
                        resting = false;
                        break;

                    default:
                        Console.WriteLine("Invalid option.");

                        Console.WriteLine("\nPress any key to continue...");
                        Console.ReadKey();
                        break;
                }
            }
        }
    }
}
