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
        public override void Update(Creature[,] board, int posX, int posY)
        {
            base.Update(board, posX, posY);
            if(Health == MinHealth)
            {
                //dead
                board[posX, posY] = null;
                return;
            }
            Random rnd = RandomGeneratorSingleton.Instance.Generator;
            //breeding
            //if health reaches maxhealth predator clones and sets its health and offsprings evenly
            if (Health == MaxHealth)
            {
                //random move
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
                        Predator offspring = new Predator
                        {
                            Health = Health / 2
                        };
                        Health /= 2;
                        board[posX + xMoveOffspring, posY + yMoveOffspring] = offspring;
                    }
                }
            }
            Health--;
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
                if (board[posX + xMove, posY + yMove] == null)
                {
                    //cell is not occupied
                    board[posX + xMove, posY + yMove] = this;
                    board[posX, posY] = null;
                }
                else if(board[posX + xMove, posY + yMove] is Prey)
                {
                    Health += 10;
                    //eating a prey
                    board[posX + xMove, posY + yMove] = this;
                    board[posX, posY] = null;
                }
            }

        }
    }
}
