using System;

namespace TheFightGame
{
    class Battle
    {
        public static void Fight(Warrior warrior1, Warrior warrior2)
        {
            while(true)
            {
                if(GetBattleResults(warrior1, warrior2) == "Game Over")
                {
                    Console.WriteLine("{0} WINS!!!", warrior1.Name);
                    break;
                }

                if(GetBattleResults(warrior2, warrior1) == "Game Over")
                {
                    Console.WriteLine("{0} WINS!!!", warrior2.Name);
                    break;
                }
            }
        }

        public static string GetBattleResults(Warrior warriorA, Warrior warriorB)
        {
            double WarAAttack = warriorA.GetAttackValue();
            double WarBBlock = warriorB.GetBlockValue();

            double DamageDealt = WarAAttack - WarBBlock;

            if (DamageDealt > 0)
            {
                warriorB.Health -= DamageDealt;
            }
            else DamageDealt = 0;

            Console.WriteLine("{0} attacks {1} with {2} damage!", 
                warriorA.Name, warriorB.Name, DamageDealt);

            if (warriorB.Health <= 0)
            {
                return "Game Over";
            }

            Console.WriteLine("{0} has {1} health", 
                warriorB.Name, warriorB.Health);

            return "Fight Again";
        }
    }
}
