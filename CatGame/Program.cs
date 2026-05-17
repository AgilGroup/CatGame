namespace CatGame
{
    internal class Program
    {
        private static ConsoleColor[] TextColor =
        {
            ConsoleColor.DarkMagenta,
            ConsoleColor.Blue,
            ConsoleColor.Cyan,
            ConsoleColor.Green,
            ConsoleColor.Yellow,
            ConsoleColor.DarkYellow,
            ConsoleColor.Red
        };

        static void Main(string[] args)
        {
            bool tryAgain = true;

            while (tryAgain)
            {
                // Reset running every time a new game starts
                bool running = true;

                Console.Clear();

                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.WriteLine("░█▀▀░█▀█░█▀▄░█▀▀░█▀▀░▀█▀░░░█▀▀░█▀█░▀█▀░░░█▀▀░█▀▀░█▀▀░█▀█░█▀█░█▀▀\r\n░█▀▀░█░█░█▀▄░█▀▀░▀▀█░░█░░░░█░░░█▀█░░█░░░░█▀▀░▀▀█░█░░░█▀█░█▀▀░█▀▀\r\n░▀░░░▀▀▀░▀░▀░▀▀▀░▀▀▀░░▀░░░░▀▀▀░▀░▀░░▀░░░░▀▀▀░▀▀▀░▀▀▀░▀░▀░▀░░░▀▀▀");

                Console.ForegroundColor = TextColor[6];
                Console.WriteLine("                   _                               ");
                Console.WriteLine("                 _(_)_                        ");
                Console.WriteLine("   @@@@         (_)@(_)  vVVVv    _     @@@@         ");
                Console.WriteLine("  @@()@@  wWWWw   (_)\\   (___)  _(_)_  @@()@@        ");
                Console.WriteLine("   @@@@   (___)     `|/    Y   (_)@(_)  @@@@           ");

                Console.ForegroundColor = TextColor[3];
                Console.WriteLine(" /\\_/\\    /       Y       \\|/    |     /(_)    \\|    /\\_/\\");
                Console.WriteLine("( o.o )  \\ |     \\ |/       | / \\ | /  \\|/       |/ ( o.o )");
                Console.WriteLine(" > ^ <  \\\\|//   \\\\|///  \\\\\\|//\\\\\\|/// \\|///  \\\\\\|//  > ^ <   ");
                Console.WriteLine(" ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^\n");

                Console.ResetColor();

                Console.WriteLine("A brave little cat is trapped inside a dark forest...");
                Console.WriteLine("Fight monsters, explore the woods, and survive!");
                Console.WriteLine("\nPress any key to continue...");
                Console.ReadKey();

                // ---------------- START MENU ----------------

                Console.Clear();

                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("=== Start Menu ===\n");
                Console.ResetColor();

                Console.WriteLine("[1] Start New Game");
                Console.WriteLine("[2] Read Instructions");
                Console.WriteLine("[3] Exit Game");

                Console.Write("\nChoose an option: ");

                bool validStartChoice = int.TryParse(Console.ReadLine(), out int startChoice);

                if (!validStartChoice)
                {
                    Console.WriteLine("Invalid choice. Exiting game.");
                    break;
                }

                if (startChoice == 2)
                {
                    Console.Clear();

                    Console.WriteLine("=== Game Instructions ===\n");
                    Console.WriteLine("- Walk through the forest");
                    Console.WriteLine("- Fight monsters");
                    Console.WriteLine("- Rest to recover health");
                    Console.WriteLine("- Survive and escape the forest");

                    Console.WriteLine("\nPress any key to continue...");
                    Console.ReadKey();
                }
                else if (startChoice == 3)
                {
                    Console.WriteLine("Goodbye!");
                    break;
                }

                // ---------------- CAT CREATION ----------------

                Console.Clear();

                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("=== Cat Creation ===\n");
                Console.ResetColor();

                Console.Write("Enter your cat name: ");
                string? catName = Console.ReadLine();

                if (string.IsNullOrWhiteSpace(catName))
                {
                    catName = "Unknown Cat";
                }

                Console.WriteLine("\nChoose your cat breed:");
                Console.WriteLine("[1] Forest Cat  - Balanced");
                Console.WriteLine("[2] Tiger Cat   - Strong Attack");
                Console.WriteLine("[3] Persian Cat - More Health");
                Console.WriteLine("[4] Black Cat   - Higher Luck");

                Console.Write("\nBreed choice: ");

                bool validBreedChoice = int.TryParse(Console.ReadLine(), out int breedChoice);

                if (!validBreedChoice || breedChoice < 1 || breedChoice > 4)
                {
                    breedChoice = 1;
                }

                string breed = "";

                switch (breedChoice)
                {
                    case 1:
                        breed = "Forest Cat";
                        break;

                    case 2:
                        breed = "Tiger Cat";
                        break;

                    case 3:
                        breed = "Persian Cat";
                        break;

                    case 4:
                        breed = "Black Cat";
                        break;
                }

                Cat player = new Cat((CatBreed)(breedChoice - 1), catName);

                Console.WriteLine($"\nWelcome {catName} the {breed}!");
                Console.WriteLine("\nPress any key to start the adventure...");
                Console.ReadKey();

                // ---------------- MAIN GAME LOOP ----------------

                while (player.Health > 0 && running)
                {
                    Console.Clear();

                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("=== Main Game Menu ===\n");
                    Console.ResetColor();

                    Console.WriteLine($"Cat: {catName} ({breed})\n");

                    Console.WriteLine("[1] Walk Through The Forest");
                    Console.WriteLine("[2] Rest");
                    Console.WriteLine("[3] Show Cat Status");
                    Console.WriteLine("[4] Exit Game");

                    Console.Write("\nEnter your choice: ");

                    bool validNumber = int.TryParse(Console.ReadLine(), out int choice);

                    if (!validNumber)
                    {
                        Console.WriteLine("Please enter a valid number.");
                        Console.ReadKey();
                        continue;
                    }

                    switch (choice)
                    {
                        case 1:
                            WalkEventService.StartWalkEvent(player);

                            Console.WriteLine("\nPress any key to continue...");
                            Console.ReadKey();
                            break;

                        case 2:
                            RestService.ShowRestMenu(player);
                            break;

                        case 3:
                            Console.Clear();

                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("=== Player Stats ===\n");
                            Console.ResetColor();

                            player.ShowStats();

                            Console.WriteLine("\nPress any key to continue...");
                            Console.ReadKey();
                            break;

                        case 4:
                            Console.WriteLine("\nThe cat escapes the forest... Game Over.");
                            running = false;

                            Console.WriteLine("\nPress any key to exit...");
                            Console.ReadKey();
                            break;

                        default:
                            Console.WriteLine("Invalid option.");
                            Console.ReadKey();
                            break;
                    }
                }

                // If player chose option 4, exit the whole game
                if (!running)
                {
                    tryAgain = false;
                    break;
                }

                // ---------------- GAME END MENU ----------------

                Console.Clear();

                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("=== Game Over ===\n");
                Console.ResetColor();

                Console.WriteLine("[1] Play Again");
                Console.WriteLine("[2] Exit");

                Console.Write("\nChoose an option: ");

                string? endChoice = Console.ReadLine();

                if (endChoice == "1")
                {
                    tryAgain = true;
                }
                else
                {
                    tryAgain = false;
                }
            }

            Console.WriteLine("Thanks for playing!");
        }
    }
}

