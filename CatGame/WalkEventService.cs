using System;

namespace CatGame
{
    internal class WalkEventService
    {
        public static void StartWalkEvent(Cat player)
        {
            Random rand = new Random();
            int eventNumber = rand.Next(1, 5);

            Console.Clear();

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\n=== Walk Event Menu ===\n");
            Console.ResetColor();

            Console.WriteLine($"{player.Name} walks deeper into the forest...\n");

            switch (eventNumber)
            {
                case 1:
                    Console.WriteLine("A wild monster appears!");

                    Enemy presetEnemy = Enemy.PresetMonsters[rand.Next(Enemy.PresetMonsters.Count)];

                    Enemy randomEnemy = new Enemy(
                        presetEnemy.Name,
                        presetEnemy.MaxHealth,
                        presetEnemy.AttackPower,
                        presetEnemy.Speed
                    );

                    FightService.StartBattle(player, randomEnemy);
                    break;

                case 2:
                    Console.WriteLine($"{player.Name} finds food and recovers health.");
                    player.Heal();
                    break;

                case 3:
                    Console.WriteLine($"{player.Name} finds a safe resting place and recovers 30 health.");

                    player.Health += 30;

                    if (player.Health > player.MaxHealth)
                    {
                        player.Health = player.MaxHealth;
                    }

                    Console.WriteLine($"Current HP: {player.Health}/{player.MaxHealth}");
                    break;

                case 4:
                    Console.WriteLine("Nothing happens... The forest is quiet.");
                    break;
            }
        }
    }
}