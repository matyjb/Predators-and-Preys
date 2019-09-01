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
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            sfmlCanvas.OnDraw += SfmlCanvas_OnDraw;
        }

        private void SfmlCanvas_OnDraw(RenderWindow window)
        {
            CircleShape cs = new CircleShape(5) { FillColor = Color.Cyan };
            window.Draw(cs);
        }
    }
}
