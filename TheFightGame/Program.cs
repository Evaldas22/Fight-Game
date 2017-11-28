using System;

namespace TheFightGame
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            string name1, name2;
            double health1, health2;
            double attk1, attk2;
            double blk1, blk2;
            */

            Console.Write("Please enter first warrior name: ");
            string name1 = Console.ReadLine();

            Console.Write("Please enter first warrior health: ");
            double health1 = double.Parse(Console.ReadLine());

            Console.Write("Please enter first warrior maximum attack: ");
            double atk1 = double.Parse(Console.ReadLine());

            Console.Write("Please enter first warrior maximum block: ");
            double blk1 = double.Parse(Console.ReadLine());

            //**********************

            Console.Write("Please enter second warrior name: ");
            string name2 = Console.ReadLine();

            Console.Write("Please enter second warrior health: ");
            double health2 = double.Parse(Console.ReadLine());

            Console.Write("Please enter second warrior maximum attack: ");
            double atk2 = double.Parse(Console.ReadLine());

            Console.Write("Please enter second warrior maximum block: ");
            double blk2 = double.Parse(Console.ReadLine());
            
            // Creating two warrior objects and making them fight
            Warrior warrior1 = new Warrior(name1, health1, atk1, blk1);

            Warrior warrior2 = new Warrior(name2, health2, atk2, blk2);

            Battle.Fight(warrior1, warrior2);
        }
    }
}
