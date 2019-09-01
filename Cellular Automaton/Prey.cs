using SFML.Graphics;
using System;

namespace Cellular_Automaton
{
    class Prey : Creature
    {
        public Prey()
        {
            Health = 1;
            MaxHealth = 20;
            Color = Color.Green;
        }
        public override void Update(Creature[,] board, int posX, int posY)
        {
            base.Update(board, posX, posY);
            Health++;
            Random rnd = RandomGeneratorSingleton.Instance.Generator;
            //breeding
            //if health reaches maxhealt prey clones and resets its health to 1
            if(Health == MaxHealth)
            {
                int dirOffspring = rnd.Next(4);
                int xMoveOffspring = 0;
                int yMoveOffspring = 0;
                switch (dirOffspring)
                {
                    case 0: //y axis-
                        yMoveOffspring = -1;
                        break;
                    case 1: //y axis+
                        yMoveOffspring = 1;
                        break;
                    case 2: //x axis-
                        xMoveOffspring = -1;
                        break;
                    case 3: //x axis+ 
                        xMoveOffspring = 1;
                        break;
                }
                if (posX + xMoveOffspring >= 0 && posY + yMoveOffspring >= 0 && posX + xMoveOffspring < board.GetLength(0) && posY + yMoveOffspring < board.GetLength(1))
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
            int dir = rnd.Next(4);
            int xMove = 0;
            int yMove = 0;
            switch (dir)
            {
                case 0: //y axis-
                    yMove = -1;
                    break;
                case 1: //y axis+
                    yMove = 1;
                    break;
                case 2: //x axis-
                    xMove = -1;
                    break;
                case 3: //x axis+ 
                    xMove = 1;
                    break;
            }
            if (posX + xMove >= 0 && posY + yMove >= 0 && posX + xMove < board.GetLength(0) && posY + yMove < board.GetLength(1)) 
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
