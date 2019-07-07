namespace _02._Dungeonest_Dark
{
    using System;

    public class Dungeonest
    {
        public static void Main()
        {
            string[] rooms = Console.ReadLine().Split('|');
            int health = 100;
            int coins = 0;
            int counter = 0;

            while (health > 0 && counter < rooms.Length)
            {
                string[] command = rooms[counter].Split();
                int value = int.Parse(command[1]);
                counter++;

                switch (command[0])
                {
                    case "potion":
                        {
                            health += value;
                            if (health > 100)
                            {
                                value -= health - 100;
                                health = 100;
                            }
                            Console.WriteLine($"You healed for {value} hp.");
                            Console.WriteLine($"Current health: {health} hp.");
                            break;
                        }
                    case "chest":
                        {
                            coins += value;
                            Console.WriteLine($"You found {value} coins.");
                            break;
                        }
                    default:
                        health -= value;
                        if (health > 0)
                        {
                            Console.WriteLine($"You slayed {command[0]}.");
                            break;
                        }
                        else
                        {
                            Console.WriteLine($"You died! Killed by {command[0]}.");
                            Console.WriteLine($"Best room: {counter}");
                        }
                        break;
                }
            }

            if (health > 0)
            {
                Console.WriteLine($"You've made it!");
                Console.WriteLine($"Coins: {coins}");
                Console.WriteLine($"Health: {health}");
            }
        }
    }
}
