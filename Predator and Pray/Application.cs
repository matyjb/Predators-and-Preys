﻿using SFML.Graphics;
using SFML.System;
using SFML.Window;
using System;
using System.Collections.Generic;
using System.Threading;

namespace Predator_and_Prey
{
    class Application : RenderWindow
    {
        public int MaxHealth { get; set; }
        public int PreyBreedHealth { get; set; }
        public int PredatorBreedHealth { get; set; }
        public int SideSize { get; set; }
        Thread logic;
        Creature[,] board;

        public List<Drawable> DrawableObjects { get; set; }
        public Application(VideoMode mode, string title) : base(mode, title)
        {
            Closed += Application_Closed;
            KeyPressed += Application_KeyPressed;
            SetVerticalSyncEnabled(false);
            DrawableObjects = new List<Drawable>();
            SetFramerateLimit(60);
            SetKeyRepeatEnabled(false);
        }

        private void Application_KeyPressed(object sender, KeyEventArgs e)
        {
            if (e.Code == Keyboard.Key.P)
            {
                GenerateRandomBoard();
            }
        }

        private void Application_Closed(object sender, EventArgs e)
        {
            Close();
        }
        private void GenerateRandomBoard()
        {
            Random rnd = new Random();
            for (int i = 0; i < board.GetLength(0); i++)
            {
                for (int j = 0; j < board.GetLength(1); j++)
                {
                    int r = rnd.Next(100);
                    if (r < 50)
                        board[i, j] = null;
                    else if (r < 70)
                        board[i, j] = new Predator(SideSize, 20, MaxHealth);
                    else
                        board[i, j] = new Prey(SideSize, 20, MaxHealth);
                }
            }
        }
        public void SimulationLogic( ref int predatorsMeter, ref int preysMeter, ref Random rnd, int tickWaitTimeInMs)
        {
            while (IsOpen)
            {
                int predatorsMeterCount = 0;
                int preysMeterCount = 0;
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
                                preysMeterCount++;
                            }
                            else if (board[i, j] is Predator)
                            {
                                (board[i, j] as Predator).Update(new Vector2i(i, j));
                                (board[i, j] as Predator).Reproduce(ref board, new Vector2i(i, j), ref rnd, PredatorBreedHealth);
                                if (board[i, j].Health <= 0)
                                    board[i, j] = null;
                                else
                                    (board[i, j] as Predator).Move(ref board, new Vector2i(i, j), ref rnd);
                                predatorsMeterCount++;
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
                predatorsMeter = predatorsMeterCount;
                preysMeter = preysMeterCount;
                Thread.Sleep(tickWaitTimeInMs);
            }
        }
        public void Run()
        {
            board = new Creature[Size.X / SideSize, Size.Y / SideSize];
            GenerateRandomBoard();
            Random rnd = new Random();
            Clock fpsmeter = new Clock();
            Font arialFont = new Font("arial.ttf");
            int predatorsMeter = 0;
            int preysMeter = 0;
            Text predatorsMeterText = new Text("Predators: " + predatorsMeter.ToString(), arialFont, 30);
            Text preysMeterText = new Text("Preys: " + preysMeter.ToString(), arialFont, 30) { Position = new Vector2f(0, 32) };
            Text fpsMeterText = new Text("", arialFont, 20) { Position = new Vector2f(0, Size.Y - 21) };

            Vertex[] v = new Vertex[4];

            logic = new Thread(() => SimulationLogic(ref predatorsMeter, ref preysMeter, ref rnd, 40));
            logic.Start();

            while (IsOpen)
            {
                DispatchEvents();
                Clear();
                for (int i = 0; i < board.GetLength(0); i++)
                {
                    for (int j = 0; j < board.GetLength(1); j++)
                    {
                        v[0].Position = new Vector2f(SideSize * i + 1, SideSize * j + 1);
                        v[1].Position = new Vector2f(SideSize * (i + 1) - 1, SideSize * j + 1);
                        v[2].Position = new Vector2f(SideSize * (i + 1) - 1, SideSize * (j + 1) - 1);
                        v[3].Position = new Vector2f(SideSize * i + 1, SideSize * (j + 1) - 1);

                        if (board[i, j] != null)
                        {
                            if (board[i, j] is Prey)
                            {
                                v[0].Color = Color.Green;
                                v[1].Color = Color.Green;
                                v[2].Color = Color.Green;
                                v[3].Color = Color.Green;
                            }
                            else if (board[i, j] is Predator)
                            {
                                v[0].Color = Color.Red;
                                v[1].Color = Color.Red;
                                v[2].Color = Color.Red;
                                v[3].Color = Color.Red;
                            }
                            Draw(v, PrimitiveType.Quads, RenderStates.Default);
                        }
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
