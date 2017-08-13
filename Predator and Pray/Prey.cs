using SFML.Graphics;
using SFML.System;
using System;

namespace Predator_and_Prey
{
    class Prey : Creature
    {
        public Prey(float sideSize, int health, int maxHealth) : base(sideSize, health, maxHealth)
        {
        }
        public override void Update(Vector2i currentCoordinatesOnBoard)
        {
            Heal(1);
            Position = (Vector2f)currentCoordinatesOnBoard * SideSize;
        }
        public override void Reproduce(ref Creature[,] board, Vector2i currentCoordinatesOnBoard, ref Random rnd, int healthAmountToReproduce)
        {
            if (Health >= healthAmountToReproduce)
            {
                int dir;
                dir = rnd.Next(4);
                switch (dir)
                {
                    case 0://up
                        if (currentCoordinatesOnBoard.X > 0)
                        {
                            if (!(board[currentCoordinatesOnBoard.X - 1, currentCoordinatesOnBoard.Y] is Creature))
                            {
                                board[currentCoordinatesOnBoard.X - 1, currentCoordinatesOnBoard.Y] = new Prey(SideSize, 1, MaxHealth);
                                Health = 1;
                            }
                        }
                        break;
                    case 1://down
                        if (currentCoordinatesOnBoard.X < board.GetLength(0) - 1)
                        {
                            if (!(board[currentCoordinatesOnBoard.X + 1, currentCoordinatesOnBoard.Y] is Creature))
                            {
                                board[currentCoordinatesOnBoard.X + 1, currentCoordinatesOnBoard.Y] = new Prey(SideSize, 1, MaxHealth);
                                Health = 1;
                            }
                        }
                        break;
                    case 2://left
                        if (currentCoordinatesOnBoard.Y > 0)
                        {
                            if (!(board[currentCoordinatesOnBoard.X, currentCoordinatesOnBoard.Y - 1] is Creature))
                            {
                                board[currentCoordinatesOnBoard.X, currentCoordinatesOnBoard.Y - 1] = new Prey(SideSize, 1, MaxHealth);
                                Health = 1;
                            }
                        }
                        break;
                    case 3://right
                        if (currentCoordinatesOnBoard.Y < board.GetLength(1) - 1)
                        {
                            if (!(board[currentCoordinatesOnBoard.X, currentCoordinatesOnBoard.Y + 1] is Creature))
                            {
                                board[currentCoordinatesOnBoard.X, currentCoordinatesOnBoard.Y + 1] = new Prey(SideSize, 1, MaxHealth);
                                Health = 1;
                            }
                        }
                        break;
                }
            }
        }
    }
}
