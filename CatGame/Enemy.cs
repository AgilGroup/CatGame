using System;
using System.Collections.Generic;
using System.Text;

namespace CatGame
{
    public class Enemy
    {
        public string Name { get; set; }
        public int Health { get; set; }
        public int MaxHealth { get; set; }
        public int AttackPower { get; set; }
        public int Speed { get; set; }


        public Enemy(string name, int health, int attackPower, int speed)
        {
            Name = name;
            MaxHealth = health;
            Health = MaxHealth;
            AttackPower = attackPower;
            Speed = speed;
        }

         // Preset monster list
        public static List<Enemy> PresetMonsters = new List<Enemy>()
        {
            new Enemy("Rat", 20, 5, 10),
            new Enemy("Goblin", 35, 8, 7),
            new Enemy("Wolf", 50, 12, 15),
            new Enemy("Skeleton", 40, 10, 5),
            new Enemy("Dragon", 150, 16, 20)
        };


        public void Attack(Cat target)
        {
            Console.WriteLine($"{Name} attacks {target.Name} for {AttackPower} damage!");
            target.Health -= AttackPower;

        }

        
    }
}