using SFML.Graphics;
using System;

namespace Cellular_Automaton
{
    public abstract class Creature
    {
        private int _health = 100;
        public int Health { get => _health; set { _health = Math.Min(Math.Max(value, MinHealth), MaxHealth); } }
        public int MaxHealth { get; protected set; } = 100;
        public int MinHealth { get; protected set; } = 0;
        public Color Color { get; set; } = Color.White;

        public virtual void Update(Creature[,] board, int posX, int posY) { }
    }
}
