using System;

namespace TheFightGame
{
    class Warrior
    {
        //A warrior must have a Name, Health, MaxAttack, MaxBlock
        public string Name { get; set; } = "Warrior";
        public double Health { get; set; } = 0;
        public double MaxAttack { get; set; } = 0;
        public double MaxBlock { get; set; } = 0;

        Random rnd = new Random();

        //Constructor for warrior object
        public Warrior(string name, double health, double maxAttack, double maxBlock)
        {
            Name = name;
            Health = health;
            MaxAttack = maxAttack;
            MaxBlock = maxBlock;
        }

        //Calculate the random attack value between 0 and MaxAttack
        public double GetAttackValue()
        {
            return rnd.Next(0, (int)MaxAttack);
        }

        //Calculate the random block value between 0 and MaxBlock
        public double GetBlockValue()
        {
            return rnd.Next(0, (int)MaxBlock);
        }
    }
}
