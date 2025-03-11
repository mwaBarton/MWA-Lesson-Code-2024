using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using L157___Polymorphism;

namespace L157___Polymorphism
{
    internal class Character
    {
        protected int hitPoints;
        protected int damage;
        public Character(int hp, int dmg)
        {
            hitPoints = hp;
            damage = dmg;
        }
        public Character(int hp)
        {
            hitPoints = hp;
            damage = 0;
        }
        public int Attack()
        {
            return damage;
        }
        public bool TakeDamage(int dmg)
        {
            hitPoints -= dmg;
            return hitPoints <= 0;
        }

        public virtual void Speak()
        {
            Console.WriteLine("Hello, I am a character.");
        }
    }

    internal class Player : Character
    {
        private string item;
        public Player(int hp, int dmg, string startingItem) : base(hp, dmg)
        {
            item = startingItem;
        }
        public void GiveItem(string newItem)
        {
            if (item == "nothing")
            {
                item = newItem;
            }
        }
        public string DropItem()
        {
            string temp = item;
            item = "nothing";
            return temp;
        }

        public void Speak()
        {
            Console.WriteLine("Hello, I am a player!");
        }
    }
}

internal class Program
{
    static void Main(string[] args)
    {
        Player p = new Player(100, 50, "cat");
        Character enemy = new Character(2000, 80);

        bool enemyDead = enemy.TakeDamage(p.Attack());
        bool playerDead = p.TakeDamage(enemy.Attack());

        if (playerDead) {
            Console.WriteLine("Player died");
        } else
        {
            Console.WriteLine("Player dropped the " + p.DropItem());
            if (enemyDead) p.GiveItem("corpse");
            else p.GiveItem("banana");

            Console.WriteLine(p.DropItem());
        }


        Character pChar = p;

        //enemy.Speak();
        //pChar.Speak();

        List<Character> chars = new List<Character>();
        chars.Add(enemy);
        chars.Add(p);
        chars.Add(new Character(5));
        chars.Add(new Player(5, 3, "bob"));

        foreach (Character c in chars)
        {
            c.Speak();
        }


        Console.ReadKey();
    }
}

