using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SFML.Graphics;
using SFML.Window;
using SFML.System;

namespace Cellular_Automaton
{
    public partial class SfmlCanvas : UserControl
    {
        private RenderWindow RendWind;
        public SfmlCanvas()
        {
            InitializeComponent();
        }

        public void StartSLMF()
        {
            if (!renderLoopWorker.IsBusy)
                renderLoopWorker.RunWorkerAsync(Handle);
        }

        private void SfmlCanvas_Load(object sender, EventArgs e)
        {
            StartSLMF();
        }

        private void RenderLoopWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            ContextSettings contextSettings = new ContextSettings() { AntialiasingLevel = 8 };
            RendWind = new RenderWindow((IntPtr)e.Argument, contextSettings);
            RendWind.SetFramerateLimit(60);


            Clock clock = new Clock();
            while (RendWind.IsOpen)
            {
                Time elapsed = clock.ElapsedTime;
                clock.Restart();
                RendWind.DispatchEvents();
                RendWind.Clear(new Color(BackColor.R, BackColor.G, BackColor.B));

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
