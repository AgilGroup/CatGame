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
            Health = health;
            AttackPower = attackPower;
            Speed = speed;
        }


        public void Attack(Cat target)
        {
            Console.WriteLine($"{Name} attacks {target.Name} for {AttackPower} damage!");
            target.Health -= AttackPower;

        }

        
    }
}