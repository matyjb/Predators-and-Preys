using SFML.Graphics;
using SFML.System;
using SFML.Window;
using System;
using System.Collections.Generic;
using System.Threading;

namespace Predator_and_Prey
{
    public class Application : RenderWindow
    {
        public int MaxHealthPredator { get; set; }
        public int MaxHealthPrey { get; set; }
        public int PreyBreedHealth { get; set; }
        public int PredatorBreedHealth { get; set; }
        public int SimulationTickWaitTime { get; set; }
        public bool SimulationRunning { get; set; }
        public bool IsSimLogicWorking { get; set; }
        public Color PreysColor { get; set; }
        public Color PredatorsColor { get; set; }
        public Color BackgroundColor { get; set; }

        public float SideSize { get; set; }
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

            SideSize = 10;
            PreyBreedHealth = 20;
            PredatorBreedHealth = 100;
            MaxHealthPredator = 1000;
            MaxHealthPrey = 1000;
            SimulationTickWaitTime = 40;
            SimulationRunning = true;

            PreysColor = Color.Green;
            PredatorsColor = Color.Red;
            BackgroundColor = Color.Black;
        }
        public Application(uint width,uint height, string title) : this(new VideoMode(width,height), title)
        {
        }

        private void Application_KeyPressed(object sender, KeyEventArgs e)
        {
            if (e.Code == Keyboard.Key.P)
            {
                GenerateRandomBoard();
            }
            if (e.Code == Keyboard.Key.O)
            {
                SimulationRunning = !SimulationRunning;
            }
        }

        private void Application_Closed(object sender, EventArgs e)
        {
            Close();
        }
        public void GenerateRandomBoard()
        {
            bool lastStateOfSimulationRunning = SimulationRunning;
            SimulationRunning = false;
            while(IsSimLogicWorking)
            {
                //waiting to stop making changes to board
            }

            board = new Creature[Size.X / (int)SideSize, Size.Y / (int)SideSize];
            Random rnd = new Random();
            for (int i = 0; i < board.GetLength(0); i++)
            {
                for (int j = 0; j < board.GetLength(1); j++)
                {
                    int r = rnd.Next(100);
                    if (r < 50)
                        board[i, j] = null;
                    else if (r < 70)
                        board[i, j] = new Predator(SideSize, 20, MaxHealthPredator);
                    else
                        board[i, j] = new Prey(SideSize, 20, MaxHealthPrey);
                }
            }
            SimulationRunning = lastStateOfSimulationRunning; //resuming logic if was already running
        }
        public void SimulationLogic(ref int predatorsMeter, ref int preysMeter, ref Random rnd)
        {
            while (IsOpen)
            {
                if (SimulationRunning)
                {
                    IsSimLogicWorking = true;
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
                                    (board[i, j] as Prey).Update(new Vector2i(i, j), SideSize);
                                    (board[i, j] as Prey).Reproduce(ref board, SideSize, new Vector2i(i, j), ref rnd, PreyBreedHealth);
                                    (board[i, j] as Prey).Move(ref board, new Vector2i(i, j), ref rnd);
                                    preysMeterCount++;
                                }
                                else if (board[i, j] is Predator)
                                {
                                    (board[i, j] as Predator).Update(new Vector2i(i, j), SideSize);
                                    (board[i, j] as Predator).Reproduce(ref board, SideSize, new Vector2i(i, j), ref rnd, PredatorBreedHealth);
                                    if (board[i, j].Health <= 0)
                                        board[i, j] = null;
                                    else
                                        (board[i, j] as Predator).Move(ref board, new Vector2i(i, j), ref rnd);
                                    predatorsMeterCount++;
                                }
                                else if (board[i, j] is Creature)
                                {
                                    board[i, j].Update(new Vector2i(i, j), SideSize);
                                    board[i, j].Reproduce(ref board, SideSize, new Vector2i(i, j), ref rnd, 20);
                                    board[i, j].Move(ref board, new Vector2i(i, j), ref rnd);
                                }
                            }
                        }
                    }
                    predatorsMeter = predatorsMeterCount;
                    preysMeter = preysMeterCount;
                    Thread.Sleep(SimulationTickWaitTime);
                }
                else
                {
                    IsSimLogicWorking = false;
                }
            }
        }
        public void Run()
        {
            board = new Creature[Size.X / (int)SideSize, Size.Y / (int)SideSize];
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

            logic = new Thread(() => SimulationLogic(ref predatorsMeter, ref preysMeter, ref rnd));
            logic.Start();

            while (IsOpen)
            {
                DispatchEvents();
                Clear(BackgroundColor);
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
                                v[0].Color = PreysColor;
                                v[1].Color = PreysColor;
                                v[2].Color = PreysColor;
                                v[3].Color = PreysColor;
                            }
                            else if (board[i, j] is Predator)
                            {
                                v[0].Color = PredatorsColor;
                                v[1].Color = PredatorsColor;
                                v[2].Color = PredatorsColor;
                                v[3].Color = PredatorsColor;
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
