using System;
using System.Windows.Forms;
using SFML.System;
using SFML.Graphics;

namespace Cellular_Automaton
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            board = new Creature[BoardSize, BoardSize];
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            sfmlCanvas.OnUpdate += SfmlCanvas_OnUpdate;
            sfmlCanvas.OnDraw += SfmlCanvas_OnDraw;
            sfmlCanvas.OnInit += SfmlCanvas_OnInit;
        }

        private void SfmlCanvas_OnInit(RenderWindow window)
        {
            window.MouseButtonPressed += Window_MouseButtonPressed;
            window.MouseButtonReleased += Window_MouseButtonReleased;
            window.MouseMoved += Window_MouseMoved;
            window.SetFramerateLimit(20);
        }

        private void Window_MouseMoved(object sender, SFML.Window.MouseMoveEventArgs e)
        {
            tool.HandleMouseButtonMoved(this, e, toolOptions);
        }

        private void Window_MouseButtonReleased(object sender, SFML.Window.MouseButtonEventArgs e)
        {
            tool.HandleMouseButtonReleased(this, e, toolOptions);
        }

        private void Window_MouseButtonPressed(object sender, SFML.Window.MouseButtonEventArgs e)
        {
            tool.HandleMouseButtonPressed(this, e, toolOptions);
        }

        public int BoardSize = 50;
        public Creature[,] board;
        public bool IsPaused = false;
        public ToolOptions toolOptions = new ToolOptions();
        public ToolType tool;

        public SfmlCanvas GetCanvas()
        {
            return sfmlCanvas;
        }

        private void SfmlCanvas_OnUpdate(RenderWindow window, Time elapsedTime)
        {
            if (!IsPaused)
                for (int x = 0; x < board.GetLength(0); x++)
                    for (int y = 0; y < board.GetLength(1); y++)
                        board[x, y]?.Update(board, x, y);
        }


        private void SfmlCanvas_OnDraw(RenderWindow window)
        {
            for (int x = 0; x < board.GetLength(0); x++)
                for (int y = 0; y < board.GetLength(1); y++)
                    if(board[x,y] != null)
                    {
                        float xSize = window.Size.X / (float)BoardSize;
                        float ySize = window.Size.Y / (float)BoardSize;
                        RectangleShape rs = new RectangleShape(new Vector2f(xSize - 2, ySize - 2)) {
                            Position = new Vector2f(xSize * x + 1, ySize * y + 1),
                            OutlineThickness = 1,
                            OutlineColor = Color.Transparent,
                            FillColor = board[x, y].Color,
                        };
                        window.Draw(rs);
                        rs.Dispose();
                    }
        }

        private void BPredator_Click(object sender, EventArgs e)
        {
            toolOptions.CreatureType = CreatureType.Predator;
        }

        private void BPray_Click(object sender, EventArgs e)
        {
            toolOptions.CreatureType = CreatureType.Prey;
        }

        private void BPlayPause_Click(object sender, EventArgs e)
        {
            IsPaused = !IsPaused;
        }

        private void RBrush_CheckedChanged(object sender, EventArgs e)
        {
            tool = new BrushTool();
        }
    }
}
