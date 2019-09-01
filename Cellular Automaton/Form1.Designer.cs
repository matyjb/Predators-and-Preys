namespace Cellular_Automaton
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.sfmlCanvas = new Cellular_Automaton.SfmlCanvas();
            this.bPredator = new System.Windows.Forms.Button();
            this.bPray = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.bPlayPause = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rBrush = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            //
            // sfmlCanvas
            //
            this.sfmlCanvas.Anchor = (System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left);
            this.sfmlCanvas.Location = new System.Drawing.Point(12, 12);
            this.sfmlCanvas.Name = "sfmlCanvas";
            this.sfmlCanvas.Size = new System.Drawing.Size(500, 500);
            this.sfmlCanvas.TabIndex = 0;
            // 
            // bPredator
            // 
            this.bPredator.BackColor = System.Drawing.Color.Red;
            this.bPredator.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bPredator.Location = new System.Drawing.Point(6, 19);
            this.bPredator.Name = "bPredator";
            this.bPredator.Size = new System.Drawing.Size(15, 15);
            this.bPredator.TabIndex = 1;
            this.bPredator.UseVisualStyleBackColor = false;
            this.bPredator.Click += new System.EventHandler(this.BPredator_Click);
            // 
            // bPray
            // 
            this.bPray.BackColor = System.Drawing.Color.Lime;
            this.bPray.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bPray.Location = new System.Drawing.Point(27, 19);
            this.bPray.Name = "bPray";
            this.bPray.Size = new System.Drawing.Size(15, 15);
            this.bPray.TabIndex = 2;
            this.bPray.UseVisualStyleBackColor = false;
            this.bPray.Click += new System.EventHandler(this.BPray_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.bPredator);
            this.groupBox1.Controls.Add(this.bPray);
            this.groupBox1.Location = new System.Drawing.Point(508, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(75, 51);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "creatures";
            // 
            // bPlayPause
            // 
            this.bPlayPause.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.bPlayPause.Location = new System.Drawing.Point(508, 489);
            this.bPlayPause.Name = "bPlayPause";
            this.bPlayPause.Size = new System.Drawing.Size(75, 23);
            this.bPlayPause.TabIndex = 4;
            this.bPlayPause.Text = "Play/Pause";
            this.bPlayPause.UseVisualStyleBackColor = true;
            this.bPlayPause.Click += new System.EventHandler(this.BPlayPause_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.rBrush);
            this.groupBox2.Location = new System.Drawing.Point(508, 69);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(75, 51);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "tools";
            // 
            // rBrush
            // 
            this.rBrush.AutoSize = true;
            this.rBrush.Location = new System.Drawing.Point(7, 20);
            this.rBrush.Name = "rBrush";
            this.rBrush.Size = new System.Drawing.Size(51, 17);
            this.rBrush.TabIndex = 0;
            this.rBrush.TabStop = true;
            this.rBrush.Text = "brush";
            this.rBrush.UseVisualStyleBackColor = true;
            this.rBrush.CheckedChanged += new System.EventHandler(this.RBrush_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(595, 524);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.bPlayPause);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.sfmlCanvas);
            this.MinimumSize = new System.Drawing.Size(500, 500);
            this.Name = "Form1";
            this.Text = "Cellular Automaton";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private SfmlCanvas sfmlCanvas;
        private System.Windows.Forms.Button bPredator;
        private System.Windows.Forms.Button bPray;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button bPlayPause;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rBrush;
    }
}

