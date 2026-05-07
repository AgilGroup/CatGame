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

            Console.WriteLine("A small cat is lost in a dark forest...");
            Console.WriteLine("The cat must survive, explore, fight, heal and escape.");
            Console.WriteLine("\nPress any key to start...");
            Console.ReadKey();

            while (running)
            {
                Console.Clear();

                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("=== Forest Cat Escape ===\n");
                Console.ResetColor();

                Console.WriteLine("What should the cat do?\n");
                Console.WriteLine("[1] Run");
                Console.WriteLine("[2] Heal");
                Console.WriteLine("[3] Fight");
                Console.WriteLine("[4] Explore");
                Console.WriteLine("[5] Meow");
                Console.WriteLine("[6] Leave Game");

                Console.Write("\nEnter your choice: ");

                bool validNumber = int.TryParse(Console.ReadLine(), out int choice);

                if (!validNumber)
                {
                    Console.WriteLine("Please enter a number.");
                    Console.ReadKey();
                    continue;
                }

                switch (choice)
                {
                    case 1:
                        Console.WriteLine("The cat runs quickly between the trees!");
                        break;

                    case 2:
                        Console.WriteLine("The cat rests and heals its wounds.");
                        break;

                    case 3:
                        Console.WriteLine("The cat fights a wild forest creature!");
                        break;

                    case 4:
                        Console.WriteLine("The cat explores the forest and searches for a way out.");
                        break;

                    case 5:
                        Console.WriteLine("Meow! The cat calls for help.");
                        break;

                    case 6:
                        Console.WriteLine("The cat leaves the forest... Game over.");
                        running = false;
                        break;

                    default:
                        Console.WriteLine("Invalid option.");
                        break;
                }

                Console.WriteLine("\nPress any key to continue...");
                Console.ReadKey();
            }
        }
    }
}
