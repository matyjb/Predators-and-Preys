using System;

namespace Cellular_Automaton
{
    class RandomGeneratorSingleton
    {
        public Random Generator { get; private set; } = new Random();
        public static RandomGeneratorSingleton Instance { get; } = new RandomGeneratorSingleton();
        static RandomGeneratorSingleton()
        {
        }
        private RandomGeneratorSingleton()
        {
        }
    }
}
