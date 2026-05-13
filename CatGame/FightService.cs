using System;
using System.Collections.Generic;
using System.Text;

namespace CatGame
{
    public static class FightService
    {
        // Main fight action
        public static void Fight(Cat player, Enemy enemy)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($"\n{player.Name} attacks {enemy.Name}!");
            Console.ResetColor();

            enemy.Health -= player.AttackPower;

            if (enemy.Health < 0)
                enemy.Health = 0;

            Console.WriteLine($"{enemy.Name} HP: {enemy.Health}");

            // Enemy defeated
            if (enemy.Health <= 0)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"{enemy.Name} has been defeated!");
                Console.ResetColor();
                return;
            }

            // Enemy attacks back
            EnemyTurn(player, enemy);
        }

        // Enemy attack turn
        public static void EnemyTurn(Cat player, Enemy enemy)
        {
            Thread.Sleep(600);

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"\n{enemy.Name} counterattacks!");
            Console.ResetColor();

            enemy.Attack(player);

            if (player.Health < 0)
                player.Health = 0;

            Console.WriteLine($"{player.Name} HP: {player.Health}/{player.MaxHealth}");

            if (player.Health <= 0)
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine($"{player.Name} has been defeated...");
                Console.ResetColor();
            }
            Console.WriteLine("\nPress any key...");
            Console.ReadKey();
        }

        // Escape function
        public static void RunAway(Cat player)
        {
            Random random = new Random();

            int chance = random.Next(1, 101);

            if (chance <= 70)
            {
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine($"{player.Name} escaped successfully!");
                Console.ResetColor();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"{player.Name} failed to escape!");
                Console.ResetColor();
            }
            Console.ResetColor();
        }

        // Meow skill
        public static void Meow(Cat player, Enemy enemy)
        {
            Console.WriteLine($"{player.Name} lets out a terrifying meow!");

            Random random = new Random();

            int chance = random.Next(1, 101);

            if (chance <= 40)
            {
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.WriteLine($"{enemy.Name} got scared and ran away!");
                Console.ResetColor();

                enemy.Health = 0;
            }
            else
            {
                Console.WriteLine("The meow had no effect...");

                EnemyTurn(player, enemy);
            }
            Console.ResetColor();
            Console.WriteLine("\nPress any key...");
            Console.ReadKey();
        }

        // Show player health
        public static void ShowHealth(Cat player)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"\n=== {player.Name} Stats ===");
            Console.WriteLine($"HP: {player.Health}/{player.MaxHealth}");
            Console.WriteLine($"Attack: {player.AttackPower}");
            Console.WriteLine($"Speed: {player.Speed}");
            Console.ResetColor();
            Console.WriteLine("\nPress any key...");
            Console.ReadKey();
        }

        // Check if battle is over
        public static bool IsBattleOver(Cat player, Enemy enemy)
        {
            return player.Health <= 0 || enemy.Health <= 0;
        }

        // Full battle loop
        public static void StartBattle(Cat player, Enemy enemy)
        {
            Console.Clear();

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"\nA wild {enemy.Name} appears!");
            Console.ResetColor();

            Console.WriteLine("\nPress any key to continue...");
            Console.ReadKey();

            while (!IsBattleOver(player, enemy))
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("=== BATTLE ===");
                Console.WriteLine($"{enemy.Name} HP: {enemy.Health}");
                Console.ResetColor();

                Console.WriteLine("\n=== Your Action ===");
                Console.WriteLine("[1] Attack Monster");
                Console.WriteLine("[2] Run Away");
                Console.WriteLine("[3] Meow To Scare Monster");
                Console.WriteLine("[4] Show Health");

                Console.Write("\nChoose an option: ");
                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        Fight(player, enemy);
                        break;

                    case "2":
                        RunAway(player);
                        return;

                    case "3":
                        Meow(player, enemy);
                        break;

                    case "4":
                        ShowHealth(player);
                        break;

                    default:
                        Console.WriteLine("Invalid choice.");
                        break;
                }
            }
            Console.Clear();

            if (player.Health > 0)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"\n{player.Name} won the battle!");
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine($"\n{player.Name} lost the battle...");
            }

            Console.ResetColor();
        }

    }
}
