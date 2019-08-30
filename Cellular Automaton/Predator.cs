using SFML.Graphics;
using System;

namespace Cellular_Automaton
{
    class Predator : Creature
    {
        public Predator()
        {
            Health = MaxHealth / 2;
            Color = Color.Red;
        }
        public override void OnUpdate(Creature[,] board, int posX, int posY)
        {
            base.OnUpdate(board, posX, posY);
            Health--;
            if(Health == MinHealth)
            {
                //dead
                board[posX, posY] = null;
                return;
            }
            Random rnd = new Random();
            //breeding
            //if health reaches maxhealt predator clones and sets its health and offsprings evenly
            if (Health == MaxHealth)
            {
                int xMoveOffspring = rnd.Next(2) == 0 ? -1 : 1;
                int yMoveOffspring = rnd.Next(2) == 0 ? -1 : 1;
                if (posX + xMoveOffspring > 0 && posY + yMoveOffspring > 0 && posX + xMoveOffspring < board.GetLength(0) && posY + yMoveOffspring < board.GetLength(1))
                {
                    //new position is in bounds
                    if (board[posX + xMoveOffspring, posY + yMoveOffspring] == null)
                    {
                        //cell is not occupied
                        Predator offspring = new Predator();
                        offspring.Health = Health / 2;
                        Health /= 2;
                        board[posX + xMoveOffspring, posY + yMoveOffspring] = offspring;
                    }
                }
            }
            //random move
            int xMove = rnd.Next(2) == 0 ? -1 : 1;
            int yMove = rnd.Next(2) == 0 ? -1 : 1;
            if (posX + xMove > 0 && posY + yMove > 0 && posX + xMove < board.GetLength(0) && posY + yMove < board.GetLength(1))
            {
                //new position is in bounds
                if (board[posX + xMove, posY + yMove] == null)
                {
                    //cell is not occupied
                    board[posX + xMove, posY + yMove] = this;
                    board[posX, posY] = null;
                }
                else if(board[posX + xMove, posY + yMove] is Prey)
                {
                    Health += 20;
                    //eating a prey
                    board[posX + xMove, posY + yMove] = this;
                    board[posX, posY] = null;
                }
            }
        }
    }
}
