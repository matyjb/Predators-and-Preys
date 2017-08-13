using SFML.Graphics;
using SFML.System;
using SFML.Window;
using System;
using System.Collections.Generic;

namespace Predator_and_Prey
{
    class Application : RenderWindow
    {
        public int MaxHealth { get; set; }
        public int PreyBreedHealth { get; set; }
        public int PredatorBreedHealth { get; set; }
        public int SideSize { get; set; }

        public List<Drawable> DrawableObjects { get; set; }
        public Application(VideoMode mode, string title) : base(mode, title)
        {
            Closed += Application_Closed;
            SetVerticalSyncEnabled(false);
            DrawableObjects = new List<Drawable>();
            SetFramerateLimit(60);
        }

        private void Application_Closed(object sender, EventArgs e)
        {
            Close();
        }
        private void GenerateRandomBoard(ref Creature[,] board)
        {
            Random rnd = new Random();
            for (int i = 0; i < board.GetLength(0); i++)
            {
                for (int j = 0; j < board.GetLength(1); j++)
                {
                    int r = rnd.Next(100);
                    if (r < 33)
                        board[i, j] = null;
                    else if (r < 50)
                        board[i, j] = new Predator(SideSize, 20, MaxHealth);
                    else
                        board[i, j] = new Prey(SideSize, 20, MaxHealth);
                }
            }
        }
        public void Run()
        {
            Creature[,] board = new Creature[Size.X / SideSize, Size.Y / SideSize];
            GenerateRandomBoard(ref board);
            Random rnd = new Random();
            Clock fpsmeter = new Clock();
            Font arialFont = new Font("arial.ttf");
            int predatorsMeter = 0;
            int preysMeter = 0;
            Text predatorsMeterText = new Text("Predators: " + predatorsMeter.ToString(), arialFont, 30);
            Text preysMeterText = new Text("Preys: " + preysMeter.ToString(), arialFont, 30) { Position = new Vector2f(0, 32) };
            Text fpsMeterText = new Text("", arialFont, 20) { Position = new Vector2f(0, Size.Y - 21) };
            while (IsOpen)
            {
                predatorsMeter = 0;
                preysMeter = 0;
                Clear();
                for (int i = 0; i < board.GetLength(0); i++)
                {
                    for (int j = 0; j < board.GetLength(1); j++)
                    {
                        if (board[i, j] != null)
                        {
                            if (board[i, j] is Prey)
                            {
                                (board[i, j] as Prey).Update(new Vector2i(i, j));
                                (board[i, j] as Prey).Reproduce(ref board, new Vector2i(i, j), ref rnd, PreyBreedHealth);
                                (board[i, j] as Prey).Move(ref board, new Vector2i(i, j), ref rnd);
                                preysMeter++;
                            }
                            else if (board[i, j] is Predator)
                            {
                                (board[i, j] as Predator).Update(new Vector2i(i, j));
                                (board[i, j] as Predator).Reproduce(ref board, new Vector2i(i, j), ref rnd, PredatorBreedHealth);
                                if (board[i, j].Health <= 0)
                                    board[i, j] = null;
                                else
                                    (board[i, j] as Predator).Move(ref board, new Vector2i(i, j), ref rnd);
                                predatorsMeter++;
                            }
                            else if (board[i, j] is Creature)
                            {
                                board[i, j].Update(new Vector2i(i, j));
                                board[i, j].Reproduce(ref board, new Vector2i(i, j), ref rnd, 20);
                                board[i, j].Move(ref board, new Vector2i(i, j), ref rnd);
                            }

                        }
                    }
                }
                RectangleShape cell = new RectangleShape(new Vector2f(SideSize, SideSize)) { OutlineColor = Color.Black, Position = new Vector2f(), OutlineThickness = 1 };
                foreach (var item in board)
                {
                    if (item != null)
                    {
                        if (item is Prey)
                            cell.FillColor = Color.Green;
                        else if (item is Predator)
                            cell.FillColor = Color.Red; 

                        cell.Position = item.Position;
                        Draw(cell);
                    }
                }
                
                predatorsMeterText.DisplayedString = "Predators: " + predatorsMeter.ToString();
                preysMeterText.DisplayedString = "Preys: " + preysMeter.ToString();
                Draw(predatorsMeterText);
                Draw(preysMeterText);
                Draw(fpsMeterText);

                Display();

                fpsMeterText.DisplayedString = ((int)(1 / fpsmeter.ElapsedTime.AsSeconds())).ToString() + " fps";
                fpsmeter.Restart();
            }
        }
    }
}
