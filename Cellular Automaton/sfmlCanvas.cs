using System;
using System.ComponentModel;
using System.Windows.Forms;
using SFML.Graphics;
using SFML.System;

namespace Cellular_Automaton
{
    public delegate void DrawEventHandler(RenderWindow window, Time elapsedTime);
    public partial class SfmlCanvas : UserControl
    {
        public RenderWindow RendWind;

        public event DrawEventHandler OnDraw;

        protected virtual void Draw(Time elapsedTime)
        {
            OnDraw?.Invoke(RendWind, elapsedTime);
        }
        public SfmlCanvas()
        {
            InitializeComponent();
        }

        private void SfmlCanvas_Load(object sender, EventArgs e)
        {
            if (!renderLoopWorker.IsBusy)
                renderLoopWorker.RunWorkerAsync(Handle);
        }

        private void RenderLoopWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            //ContextSettings contextSettings = new ContextSettings() { AntialiasingLevel = 8 };
            //RendWind.SetFramerateLimit(60);
            RendWind = new RenderWindow((IntPtr)e.Argument);
            Clock clock = new Clock();
            while (RendWind.IsOpen)
            {
                Time elapsed = clock.ElapsedTime;
                clock.Restart();
                RendWind.DispatchEvents();
                RendWind.Clear(new Color(BackColor.R, BackColor.G, BackColor.B));
                Draw(elapsed);
                RendWind.Display();
            }
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            if (RendWind == null)
                base.OnPaint(e);
        }

        protected override void OnPaintBackground(PaintEventArgs pevent)
        {
            if (RendWind == null)
                base.OnPaintBackground(pevent);
        }


    }
}
