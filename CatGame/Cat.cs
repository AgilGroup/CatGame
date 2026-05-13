using System;
using System.Collections.Generic;
using System.Text;

namespace CatGame
{
    public enum CatBreed
    {
       Forest,
       Tiger,
       Persian,
       Black
        
    }
    public class Cat
    {

        public CatBreed Breed { get; set; }
        public string Name { get; set; }
        public int Health { get; set; }
        public int MaxHealth { get; set; }
        public int AttackPower { get; set; }
        public int Speed { get; set; }
        public double CriticalHitChance { get; set; }

       


        public Cat(CatBreed breed, string name)
        {
            Breed = breed;
            Name= name;
           
            AssignStats();
        }

        // This method assigns stats to the cat based on its breed
        private void AssignStats()
        {
            switch (Breed)
            {
                case CatBreed.Forest:
                    MaxHealth = 100;
                    Health = MaxHealth;
                    AttackPower = 15;
                    Speed = 10;
                    CriticalHitChance = 0.1;
                    break;
                case CatBreed.Tiger:
                    MaxHealth = 100;
                    Health = MaxHealth;
                    AttackPower = 20;
                    Speed = 8;
                    CriticalHitChance = 0.05;
                    break;
                case CatBreed.Persian:
                    MaxHealth = 120;
                    Health = MaxHealth;
                    AttackPower = 12;
                    Speed = 12;
                    CriticalHitChance = 0.05;
                    break;
                case CatBreed.Black:
                    MaxHealth = 90;
                    Health = MaxHealth;
                    AttackPower = 12;
                    Speed = 14;
                    CriticalHitChance = 0.25;
                    break;
            }
        }



        public void Attack(Enemy target)
        {
            Random r = new Random();

            Console.WriteLine($"{Name} attacks {target.Name} for {AttackPower} damage!");
            target.Health -= AttackPower;
        }



        public void Heal()
        {
            Random r = new Random();
            int healAmount = r.Next(5, 16); 

            if (healAmount < 10)
            {
                Console.WriteLine($"{Name} tries to heal but only recovers {healAmount} health.");
                Health += healAmount;

                if (Health > MaxHealth)
                {
                    Health = MaxHealth;
                }
               
            }
            else
            {
                Console.WriteLine($"The heal is very effective! {Name} recovers {healAmount} Health");
                Health += healAmount;

                if (Health > MaxHealth)
                {
                    Health = MaxHealth;
                }
            }

            return;

        }


        public void Meow()
        {
            //this will do something later
        }
        public void ShowStats()
        {
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Health: {Health}/{MaxHealth}");
            Console.WriteLine($"Attack Power: {AttackPower}");
            Console.WriteLine($"Speed: {Speed}");
            Console.WriteLine($"Critical Hit Chance: {CriticalHitChance * 100}%");
        }


    }
}
