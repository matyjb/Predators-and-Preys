using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Predator_and_Prey;
using System.Threading;


namespace PAPControlWindow
{
    public partial class Form1 : Form
    {
        Predator_and_Prey.Application simWindow;
        private void SetControlsStartValues()
        {
            nHealthPredators.Value = simWindow.PredatorBreedHealth;
            nHealthPreys.Value = simWindow.PreyBreedHealth;
            nSideSize.Value = (decimal)simWindow.SideSize;
            nTickWaitTime.Value = simWindow.SimulationTickWaitTime;
            nMaxHealthPreys.Value = simWindow.MaxHealthPrey;
            nMaxHealthPredators.Value = simWindow.MaxHealthPredator;

            TBHealthPredators.Value = simWindow.PredatorBreedHealth;
            TBHealthPreys.Value = simWindow.PreyBreedHealth;
            TBSideSize.Value = (int)simWindow.SideSize;
            TBTickWaitTime.Value = simWindow.SimulationTickWaitTime;
            TBMaxHealthPreys.Value = simWindow.MaxHealthPrey;
            TBMaxHealthPredators.Value = simWindow.MaxHealthPredator;

            bColorPredators.BackColor = Color.Red;
            bColorPreys.BackColor = Color.Green;
            bColorBackground.BackColor = Color.Black;

        }
        public Form1()
        {
            InitializeComponent();
            simWindow = new Predator_and_Prey.Application(1600, 900, "Predators and Preys")
            {
                SideSize = 7,
                PreyBreedHealth = 20,
                PredatorBreedHealth = 70,
                MaxHealthPredator = 1000,
                MaxHealthPrey = 1000,
                SimulationTickWaitTime = 40,
                SimulationRunning = false
            };
            SetControlsStartValues();
            simWindow.SetActive(false);
            Thread simWindowThread = new Thread(new ThreadStart(simWindow.Run));
            simWindowThread.Start();
            FormClosed += Form1_FormClosed;
        }
        private SFML.Graphics.Color ConvertFromSystemDrawingColor(Color color)
        {
            return new SFML.Graphics.Color(color.R, color.G, color.B, color.A);
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            simWindow.Close();
        }

        private void bPlay_Click(object sender, EventArgs e)
        {
            bPause.Visible = true;
            bPlay.Visible = false;
            simWindow.SimulationRunning = true;
        }

        private void bPause_Click(object sender, EventArgs e)
        {
            bPause.Visible = false;
            bPlay.Visible = true;
            simWindow.SimulationRunning = false;
        }

        private void nSideSize_ValueChanged(object sender, EventArgs e)
        {
            simWindow.SideSize = (float)nSideSize.Value;
        }

        private void TBSideSize_Scroll(object sender, EventArgs e)
        {
            nSideSize.Value = TBSideSize.Value;
        }

        private void TBHealthPreys_Scroll(object sender, EventArgs e)
        {
            nHealthPreys.Value = TBHealthPreys.Value;
        }

        private void nHealthPreys_ValueChanged(object sender, EventArgs e)
        {
            simWindow.PreyBreedHealth = (int)nHealthPreys.Value;
        }

        private void TBHealthPredators_Scroll(object sender, EventArgs e)
        {
            nHealthPredators.Value = TBHealthPredators.Value;
        }

        private void nHealthPredators_ValueChanged(object sender, EventArgs e)
        {
            simWindow.PredatorBreedHealth = (int)nHealthPredators.Value;
        }

        private void bGenNew_Click(object sender, EventArgs e)
        {
            simWindow.GenerateRandomBoard();
        }

        private void TBTickWaitTime_Scroll(object sender, EventArgs e)
        {
            nTickWaitTime.Value = TBTickWaitTime.Value;
        }

        private void nTickWaitTime_ValueChanged(object sender, EventArgs e)
        {
            simWindow.SimulationTickWaitTime = (int)nTickWaitTime.Value;
        }

        private void TBMaxHealthPreys_Scroll(object sender, EventArgs e)
        {
            nMaxHealthPreys.Value = TBMaxHealthPreys.Value;
        }

        private void nMaxHealthPreys_ValueChanged(object sender, EventArgs e)
        {
            simWindow.MaxHealthPrey = (int)nMaxHealthPreys.Value;
        }

        private void TBMaxHealthPredators_Scroll(object sender, EventArgs e)
        {
            nMaxHealthPredators.Value = TBMaxHealthPredators.Value;
        }

        private void nMaxHealthPredators_ValueChanged(object sender, EventArgs e)
        {
            simWindow.MaxHealthPredator = (int)nMaxHealthPredators.Value;
        }

        private void bColorPreys_Click(object sender, EventArgs e)
        {
            colorDialog1.Color = bColorPreys.BackColor;
            var result = colorDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                bColorPreys.BackColor = colorDialog1.Color;
            }
        }

        private void bColorPredators_Click(object sender, EventArgs e)
        {
            colorDialog1.Color = bColorPredators.BackColor;
            var result = colorDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                bColorPredators.BackColor = colorDialog1.Color;
            }
        }

        private void bColorPreys_BackColorChanged(object sender, EventArgs e)
        {
            simWindow.PreysColor = ConvertFromSystemDrawingColor(bColorPreys.BackColor);
        }

        private void bColorPredators_BackColorChanged(object sender, EventArgs e)
        {
            simWindow.PredatorsColor = ConvertFromSystemDrawingColor(bColorPredators.BackColor);
        }

        private void bColorBackground_Click(object sender, EventArgs e)
        {
            colorDialog1.Color = bColorBackground.BackColor;
            var result = colorDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                bColorBackground.BackColor = colorDialog1.Color;
            }
        }

        private void bColorBackground_BackColorChanged(object sender, EventArgs e)
        {
            simWindow.BackgroundColor = ConvertFromSystemDrawingColor(bColorBackground.BackColor);
        }
    }
}
