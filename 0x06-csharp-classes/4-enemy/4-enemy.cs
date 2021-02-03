using System;

namespace Enemies
{
    class Zombie
    {
        private int health;
        private string name;

        public Zombie()
        {
            health = 0;
            name = "(No name)";
        }

        public Zombie(int value)
        {
            if (value < 0)
            {
                throw new ArgumentException("Health must be greater than or equal to 0");
            } else
            {
                health = value;
                name = "(No name)";
            }
        }

        public int GetHealth()
        {
            return health;
        }

        public string Name
        {
            get => name;
            set => name = value;
        }
        
    }
}
