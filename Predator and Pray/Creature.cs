using SFML.Graphics;
using SFML.System;
using System;

namespace Predator_and_Prey
{

    class Creature
    {
        public int Health { get; set; }
        public int MaxHealth { get; set; }
        public float SideSize { get; private set; }
        public Vector2f Position { get; set; }

        public Creature(float sideSize, int health,int maxHealth)
        {
            Health = health;
            MaxHealth = maxHealth;
            SideSize = sideSize;
        }
        public virtual void Update(Vector2i currentCoordinatesOnBoard)
        {
            Heal(0);
            Position = (Vector2f)currentCoordinatesOnBoard * SideSize;
        }
        public void Heal(int amount)
        {
            Health += amount;
            Health = Math.Max(Math.Min(Health, MaxHealth),0);
            
        }
        public virtual void Reproduce(ref Creature[,] board, Vector2i currentCoordinatesOnBoard, ref Random rnd, int healthAmountToReproduce)
        {
            //Simple creature doesnt reproduce
        }
        public virtual void Move(ref Creature[,] board, Vector2i currentCoordinatesOnBoard,ref Random rnd)
        {
            int dir = rnd.Next(4);
            switch (dir)
            {
                case 0://up
                    if (currentCoordinatesOnBoard.X > 0)
                    {
                        if (!(board[currentCoordinatesOnBoard.X - 1, currentCoordinatesOnBoard.Y] is Creature))
                        {
                            board[currentCoordinatesOnBoard.X - 1, currentCoordinatesOnBoard.Y] = this;
                            board[currentCoordinatesOnBoard.X, currentCoordinatesOnBoard.Y] = null;
                        }
                    }
                    break;
                case 1://down
                    if (currentCoordinatesOnBoard.X < board.GetLength(0) - 1)
                    {
                        if (!(board[currentCoordinatesOnBoard.X + 1, currentCoordinatesOnBoard.Y] is Creature))
                        {
                            board[currentCoordinatesOnBoard.X + 1, currentCoordinatesOnBoard.Y] = this;
                            board[currentCoordinatesOnBoard.X, currentCoordinatesOnBoard.Y] = null;
                        }
                    }
                    break;
                case 2://left
                    if (currentCoordinatesOnBoard.Y > 0)
                    {
                        if (!(board[currentCoordinatesOnBoard.X, currentCoordinatesOnBoard.Y - 1] is Creature))
                        {
                            board[currentCoordinatesOnBoard.X, currentCoordinatesOnBoard.Y - 1] = this;
                            board[currentCoordinatesOnBoard.X, currentCoordinatesOnBoard.Y] = null;
                        }
                    }
                    break;
                case 3://right
                    if (currentCoordinatesOnBoard.Y < board.GetLength(1) - 1)
                    {
                        if (!(board[currentCoordinatesOnBoard.X, currentCoordinatesOnBoard.Y + 1] is Creature))
                        {
                            board[currentCoordinatesOnBoard.X, currentCoordinatesOnBoard.Y + 1] = this;
                            board[currentCoordinatesOnBoard.X, currentCoordinatesOnBoard.Y] = null;
                        }
                    }
                    break;
            }
        }
    }
}
