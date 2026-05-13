namespace CatGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool running = true;

            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("=== Forest Cat Escape ===\n");
            Console.ResetColor();
            Console.WriteLine("                   _                               ");
            Console.WriteLine("                 _(_)_                        ");
            Console.WriteLine("   @@@@         (_)@(_)  vVVVv    _     @@@@         ");
            Console.WriteLine("  @@()@@  wWWWw   (_)\\   (___)  _(_)_  @@()@@        ");
            Console.WriteLine("   @@@@   (___)     `|/    Y   (_)@(_)  @@@@           ");
            Console.WriteLine("    /       Y       \\|/    |     /(_)    \\|              ");
            Console.WriteLine("  \\ |     \\ |/       | / \\ | /  \\|/       |/          ");
            Console.WriteLine("  \\\\|//   \\\\|///  \\\\\\|//\\\\\\|/// \\|///  \\\\\\|//  ");
            Console.WriteLine(" ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^\n");

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

            int startChoice = int.Parse(Console.ReadLine());

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
                return;
            }

            // ---------------- CAT CREATION ----------------

            Console.Clear();

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("=== Cat Creation ===\n");
            Console.ResetColor();

            Console.Write("Enter your cat name: ");
            string catName = Console.ReadLine();

            Console.WriteLine("\nChoose your cat breed:");
            Console.WriteLine("[1] Forest Cat  - Balanced");
            Console.WriteLine("[2] Tiger Cat   - Strong Attack");
            Console.WriteLine("[3] Persian Cat - More Health");
            Console.WriteLine("[4] Black Cat   - Higher Luck");

            Console.Write("\nBreed choice: ");
            int breedChoice = int.Parse(Console.ReadLine());

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

                default:
                    breed = "Unknown Cat";
                    break;
            }

            Cat player = new Cat((CatBreed)(breedChoice - 1), catName);

            Console.WriteLine($"\nWelcome {catName} the {breed}!");
            Console.WriteLine("\nPress any key to start the adventure...");
            Console.ReadKey();

            // ---------------- MAIN GAME LOOP ----------------

            while (running)
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

                        Console.Clear();

                        Console.WriteLine("The cat walks deeper into the forest...\n");

                        Random random = new Random();
                        int eventNumber = random.Next(1, 2);

                        switch (eventNumber)
                        {
                            case 1:
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine("A wild monster appears!");
                                Console.ResetColor();

                                // Pick a random monster
                                Random randomEnemyNum = new Random();
                                Enemy enemy = Enemy.PresetMonsters[randomEnemyNum.Next(Enemy.PresetMonsters.Count)];

                                FightService.StartBattle(player, enemy);

                                break;

                            case 2:
                                Console.WriteLine("The cat finds food and restores energy.");
                                break;

                            case 3:
                                Console.WriteLine("The cat finds a safe resting place.");
                                break;

                            case 4:
                                Console.WriteLine("Nothing happens... The forest is quiet.");
                                break;
                        }

                        break;

                    case 2:

                        Console.Clear();

                        Console.WriteLine("=== Rest Menu ===\n");
                        Console.WriteLine("The cat rests peacefully and recovers health.");
                        break;

                    case 3:

                        Console.Clear();

                        player.ShowStats();

                        break;

                    case 4:

                        Console.WriteLine("The cat escapes the forest... Game Over.");
                        running = false;
                        break;

                    default:

                        Console.WriteLine("Invalid option.");
                        break;
                }

                if (running)
                {
                    Console.WriteLine("\nPress any key to continue...");
                    Console.ReadKey();
                }
            }

            // ---------------- GAME END MENU ----------------

            Console.Clear();

            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("=== Game Over ===\n");
            Console.ResetColor();

            Console.WriteLine("[1] Play Again");
            Console.WriteLine("[2] Exit");

            Console.Write("\nChoose an option: ");
        }
    }
}