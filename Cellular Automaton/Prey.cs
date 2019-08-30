using SFML.Graphics;
using System;

namespace Cellular_Automaton
{
    class Prey : Creature
    {
        public Prey()
        {
            Health = 1;
            Color = Color.Green;
        }
        public override void OnUpdate(Creature[,] board, int posX, int posY)
        {
            base.OnUpdate(board, posX, posY);
            Health++;
            Random rnd = new Random();
            //breeding
            //if health reaches maxhealt prey clones and resets its health to 1
            if(Health == MaxHealth)
            {
                int xMoveOffspring = rnd.Next(2) == 0 ? -1 : 1;
                int yMoveOffspring = rnd.Next(2) == 0 ? -1 : 1;
                if (posX + xMoveOffspring > 0 && posY + yMoveOffspring > 0 && posX + xMoveOffspring < board.GetLength(0) && posY + yMoveOffspring < board.GetLength(1))
                {
                    //new position is in bounds
                    if (board[posX + xMoveOffspring, posY + yMoveOffspring] == null)
                    {
                        //cell is not occupied
                        Prey offspring = new Prey();
                        board[posX + xMoveOffspring, posY + yMoveOffspring] = offspring;
                        Health = 1;
                    }
                }
            }
            //random move
            int xMove = rnd.Next(2) == 0 ? -1 : 1; 
            int yMove = rnd.Next(2) == 0 ? -1 : 1;
            if (posX + xMove > 0 && posY + yMove > 0 && posX + xMove < board.GetLength(0) && posY + yMove < board.GetLength(1)) 
            {
                //new position is in bounds
                if(board[posX + xMove, posY + yMove] == null)
                {
                    //cell is not occupied
                    board[posX + xMove, posY + yMove] = this;
                    board[posX, posY] =null;
                }
            }
        }
    }
}
