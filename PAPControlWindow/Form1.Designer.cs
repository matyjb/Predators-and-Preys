namespace PAPControlWindow
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
            this.bPlay = new System.Windows.Forms.Button();
            this.bPause = new System.Windows.Forms.Button();
            this.TBSideSize = new System.Windows.Forms.TrackBar();
            this.lSideSize = new System.Windows.Forms.Label();
            this.nSideSize = new System.Windows.Forms.NumericUpDown();
            this.GBHealth = new System.Windows.Forms.GroupBox();
            this.nHealthPreys = new System.Windows.Forms.NumericUpDown();
            this.lHealthPreys = new System.Windows.Forms.Label();
            this.TBHealthPreys = new System.Windows.Forms.TrackBar();
            this.nHealthPredators = new System.Windows.Forms.NumericUpDown();
            this.TBHealthPredators = new System.Windows.Forms.TrackBar();
            this.lHealthPredators = new System.Windows.Forms.Label();
            this.bGenNew = new System.Windows.Forms.Button();
            this.nTickWaitTime = new System.Windows.Forms.NumericUpDown();
            this.lTickWaitTime = new System.Windows.Forms.Label();
            this.TBTickWaitTime = new System.Windows.Forms.TrackBar();
            this.GBMaxHealth = new System.Windows.Forms.GroupBox();
            this.nMaxHealthPredators = new System.Windows.Forms.NumericUpDown();
            this.TBMaxHealthPredators = new System.Windows.Forms.TrackBar();
            this.lMaxHealthPredators = new System.Windows.Forms.Label();
            this.nMaxHealthPreys = new System.Windows.Forms.NumericUpDown();
            this.TBMaxHealthPreys = new System.Windows.Forms.TrackBar();
            this.label2 = new System.Windows.Forms.Label();
            this.GBSystem = new System.Windows.Forms.GroupBox();
            this.lMaxHealthPreys = new System.Windows.Forms.Label();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.bColorPreys = new System.Windows.Forms.Button();
            this.bColorPredators = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.bColorBackground = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.TBSideSize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nSideSize)).BeginInit();
            this.GBHealth.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nHealthPreys)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TBHealthPreys)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nHealthPredators)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TBHealthPredators)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nTickWaitTime)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TBTickWaitTime)).BeginInit();
            this.GBMaxHealth.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nMaxHealthPredators)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TBMaxHealthPredators)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nMaxHealthPreys)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TBMaxHealthPreys)).BeginInit();
            this.GBSystem.SuspendLayout();
            this.SuspendLayout();
            // 
            // bPlay
            // 
            this.bPlay.Location = new System.Drawing.Point(12, 435);
            this.bPlay.Name = "bPlay";
            this.bPlay.Size = new System.Drawing.Size(50, 81);
            this.bPlay.TabIndex = 0;
            this.bPlay.Text = "resume";
            this.bPlay.UseVisualStyleBackColor = true;
            this.bPlay.Click += new System.EventHandler(this.bPlay_Click);
            // 
            // bPause
            // 
            this.bPause.Location = new System.Drawing.Point(12, 435);
            this.bPause.Name = "bPause";
            this.bPause.Size = new System.Drawing.Size(50, 81);
            this.bPause.TabIndex = 1;
            this.bPause.Text = "pause";
            this.bPause.UseVisualStyleBackColor = true;
            this.bPause.Visible = false;
            this.bPause.Click += new System.EventHandler(this.bPause_Click);
            // 
            // TBSideSize
            // 
            this.TBSideSize.Location = new System.Drawing.Point(9, 86);
            this.TBSideSize.Maximum = 100;
            this.TBSideSize.Minimum = 3;
            this.TBSideSize.Name = "TBSideSize";
            this.TBSideSize.Size = new System.Drawing.Size(260, 45);
            this.TBSideSize.TabIndex = 2;
            this.TBSideSize.TickFrequency = 5;
            this.TBSideSize.Value = 3;
            this.TBSideSize.Scroll += new System.EventHandler(this.TBSideSize_Scroll);
            // 
            // lSideSize
            // 
            this.lSideSize.AutoSize = true;
            this.lSideSize.Location = new System.Drawing.Point(6, 70);
            this.lSideSize.Name = "lSideSize";
            this.lSideSize.Size = new System.Drawing.Size(101, 13);
            this.lSideSize.TabIndex = 3;
            this.lSideSize.Text = "Side size of one cell";
            // 
            // nSideSize
            // 
            this.nSideSize.Location = new System.Drawing.Point(275, 86);
            this.nSideSize.Minimum = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.nSideSize.Name = "nSideSize";
            this.nSideSize.Size = new System.Drawing.Size(57, 20);
            this.nSideSize.TabIndex = 4;
            this.nSideSize.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.nSideSize.ValueChanged += new System.EventHandler(this.nSideSize_ValueChanged);
            // 
            // GBHealth
            // 
            this.GBHealth.Controls.Add(this.nHealthPredators);
            this.GBHealth.Controls.Add(this.TBHealthPredators);
            this.GBHealth.Controls.Add(this.lHealthPredators);
            this.GBHealth.Controls.Add(this.nHealthPreys);
            this.GBHealth.Controls.Add(this.TBHealthPreys);
            this.GBHealth.Controls.Add(this.lHealthPreys);
            this.GBHealth.Location = new System.Drawing.Point(12, 12);
            this.GBHealth.Name = "GBHealth";
            this.GBHealth.Size = new System.Drawing.Size(355, 138);
            this.GBHealth.TabIndex = 5;
            this.GBHealth.TabStop = false;
            this.GBHealth.Text = "Health required to breed";
            // 
            // nHealthPreys
            // 
            this.nHealthPreys.Location = new System.Drawing.Point(272, 35);
            this.nHealthPreys.Minimum = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.nHealthPreys.Name = "nHealthPreys";
            this.nHealthPreys.Size = new System.Drawing.Size(57, 20);
            this.nHealthPreys.TabIndex = 8;
            this.nHealthPreys.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.nHealthPreys.ValueChanged += new System.EventHandler(this.nHealthPreys_ValueChanged);
            // 
            // lHealthPreys
            // 
            this.lHealthPreys.AutoSize = true;
            this.lHealthPreys.Location = new System.Drawing.Point(3, 19);
            this.lHealthPreys.Name = "lHealthPreys";
            this.lHealthPreys.Size = new System.Drawing.Size(33, 13);
            this.lHealthPreys.TabIndex = 7;
            this.lHealthPreys.Text = "Preys";
            // 
            // TBHealthPreys
            // 
            this.TBHealthPreys.Location = new System.Drawing.Point(6, 35);
            this.TBHealthPreys.Maximum = 100;
            this.TBHealthPreys.Minimum = 3;
            this.TBHealthPreys.Name = "TBHealthPreys";
            this.TBHealthPreys.Size = new System.Drawing.Size(260, 45);
            this.TBHealthPreys.TabIndex = 6;
            this.TBHealthPreys.TickFrequency = 5;
            this.TBHealthPreys.Value = 3;
            this.TBHealthPreys.Scroll += new System.EventHandler(this.TBHealthPreys_Scroll);
            // 
            // nHealthPredators
            // 
            this.nHealthPredators.Location = new System.Drawing.Point(272, 86);
            this.nHealthPredators.Minimum = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.nHealthPredators.Name = "nHealthPredators";
            this.nHealthPredators.Size = new System.Drawing.Size(57, 20);
            this.nHealthPredators.TabIndex = 11;
            this.nHealthPredators.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.nHealthPredators.ValueChanged += new System.EventHandler(this.nHealthPredators_ValueChanged);
            // 
            // TBHealthPredators
            // 
            this.TBHealthPredators.Location = new System.Drawing.Point(6, 86);
            this.TBHealthPredators.Maximum = 100;
            this.TBHealthPredators.Minimum = 3;
            this.TBHealthPredators.Name = "TBHealthPredators";
            this.TBHealthPredators.Size = new System.Drawing.Size(260, 45);
            this.TBHealthPredators.TabIndex = 9;
            this.TBHealthPredators.TickFrequency = 5;
            this.TBHealthPredators.Value = 3;
            this.TBHealthPredators.Scroll += new System.EventHandler(this.TBHealthPredators_Scroll);
            // 
            // lHealthPredators
            // 
            this.lHealthPredators.AutoSize = true;
            this.lHealthPredators.Location = new System.Drawing.Point(3, 70);
            this.lHealthPredators.Name = "lHealthPredators";
            this.lHealthPredators.Size = new System.Drawing.Size(52, 13);
            this.lHealthPredators.TabIndex = 10;
            this.lHealthPredators.Text = "Predators";
            // 
            // bGenNew
            // 
            this.bGenNew.Location = new System.Drawing.Point(68, 435);
            this.bGenNew.Name = "bGenNew";
            this.bGenNew.Size = new System.Drawing.Size(70, 81);
            this.bGenNew.TabIndex = 6;
            this.bGenNew.Text = "Generate new board";
            this.bGenNew.UseVisualStyleBackColor = true;
            this.bGenNew.Click += new System.EventHandler(this.bGenNew_Click);
            // 
            // nTickWaitTime
            // 
            this.nTickWaitTime.Location = new System.Drawing.Point(275, 35);
            this.nTickWaitTime.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nTickWaitTime.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nTickWaitTime.Name = "nTickWaitTime";
            this.nTickWaitTime.Size = new System.Drawing.Size(57, 20);
            this.nTickWaitTime.TabIndex = 9;
            this.nTickWaitTime.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.nTickWaitTime.ValueChanged += new System.EventHandler(this.nTickWaitTime_ValueChanged);
            // 
            // lTickWaitTime
            // 
            this.lTickWaitTime.AutoSize = true;
            this.lTickWaitTime.Location = new System.Drawing.Point(6, 19);
            this.lTickWaitTime.Name = "lTickWaitTime";
            this.lTickWaitTime.Size = new System.Drawing.Size(99, 13);
            this.lTickWaitTime.TabIndex = 8;
            this.lTickWaitTime.Text = "Tick wait time in ms";
            // 
            // TBTickWaitTime
            // 
            this.TBTickWaitTime.Location = new System.Drawing.Point(9, 35);
            this.TBTickWaitTime.Maximum = 1000;
            this.TBTickWaitTime.Minimum = 1;
            this.TBTickWaitTime.Name = "TBTickWaitTime";
            this.TBTickWaitTime.Size = new System.Drawing.Size(260, 45);
            this.TBTickWaitTime.TabIndex = 7;
            this.TBTickWaitTime.TickFrequency = 10;
            this.TBTickWaitTime.Value = 3;
            this.TBTickWaitTime.Scroll += new System.EventHandler(this.TBTickWaitTime_Scroll);
            // 
            // GBMaxHealth
            // 
            this.GBMaxHealth.Controls.Add(this.lMaxHealthPreys);
            this.GBMaxHealth.Controls.Add(this.nMaxHealthPredators);
            this.GBMaxHealth.Controls.Add(this.TBMaxHealthPredators);
            this.GBMaxHealth.Controls.Add(this.lMaxHealthPredators);
            this.GBMaxHealth.Controls.Add(this.nMaxHealthPreys);
            this.GBMaxHealth.Controls.Add(this.TBMaxHealthPreys);
            this.GBMaxHealth.Controls.Add(this.label2);
            this.GBMaxHealth.Location = new System.Drawing.Point(12, 149);
            this.GBMaxHealth.Name = "GBMaxHealth";
            this.GBMaxHealth.Size = new System.Drawing.Size(355, 138);
            this.GBMaxHealth.TabIndex = 12;
            this.GBMaxHealth.TabStop = false;
            this.GBMaxHealth.Text = "Max health";
            // 
            // nMaxHealthPredators
            // 
            this.nMaxHealthPredators.Location = new System.Drawing.Point(272, 86);
            this.nMaxHealthPredators.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nMaxHealthPredators.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nMaxHealthPredators.Name = "nMaxHealthPredators";
            this.nMaxHealthPredators.Size = new System.Drawing.Size(57, 20);
            this.nMaxHealthPredators.TabIndex = 11;
            this.nMaxHealthPredators.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.nMaxHealthPredators.ValueChanged += new System.EventHandler(this.nMaxHealthPredators_ValueChanged);
            // 
            // TBMaxHealthPredators
            // 
            this.TBMaxHealthPredators.Location = new System.Drawing.Point(6, 86);
            this.TBMaxHealthPredators.Maximum = 1000;
            this.TBMaxHealthPredators.Minimum = 1;
            this.TBMaxHealthPredators.Name = "TBMaxHealthPredators";
            this.TBMaxHealthPredators.Size = new System.Drawing.Size(260, 45);
            this.TBMaxHealthPredators.TabIndex = 9;
            this.TBMaxHealthPredators.TickFrequency = 50;
            this.TBMaxHealthPredators.Value = 3;
            this.TBMaxHealthPredators.Scroll += new System.EventHandler(this.TBMaxHealthPredators_Scroll);
            // 
            // lMaxHealthPredators
            // 
            this.lMaxHealthPredators.AutoSize = true;
            this.lMaxHealthPredators.Location = new System.Drawing.Point(3, 70);
            this.lMaxHealthPredators.Name = "lMaxHealthPredators";
            this.lMaxHealthPredators.Size = new System.Drawing.Size(52, 13);
            this.lMaxHealthPredators.TabIndex = 10;
            this.lMaxHealthPredators.Text = "Predators";
            // 
            // nMaxHealthPreys
            // 
            this.nMaxHealthPreys.Location = new System.Drawing.Point(272, 35);
            this.nMaxHealthPreys.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nMaxHealthPreys.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nMaxHealthPreys.Name = "nMaxHealthPreys";
            this.nMaxHealthPreys.Size = new System.Drawing.Size(57, 20);
            this.nMaxHealthPreys.TabIndex = 8;
            this.nMaxHealthPreys.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.nMaxHealthPreys.ValueChanged += new System.EventHandler(this.nMaxHealthPreys_ValueChanged);
            // 
            // TBMaxHealthPreys
            // 
            this.TBMaxHealthPreys.Location = new System.Drawing.Point(6, 35);
            this.TBMaxHealthPreys.Maximum = 1000;
            this.TBMaxHealthPreys.Minimum = 1;
            this.TBMaxHealthPreys.Name = "TBMaxHealthPreys";
            this.TBMaxHealthPreys.Size = new System.Drawing.Size(260, 45);
            this.TBMaxHealthPreys.TabIndex = 6;
            this.TBMaxHealthPreys.TickFrequency = 50;
            this.TBMaxHealthPreys.Value = 3;
            this.TBMaxHealthPreys.Scroll += new System.EventHandler(this.TBMaxHealthPreys_Scroll);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Preys";
            // 
            // GBSystem
            // 
            this.GBSystem.Controls.Add(this.lSideSize);
            this.GBSystem.Controls.Add(this.lTickWaitTime);
            this.GBSystem.Controls.Add(this.TBTickWaitTime);
            this.GBSystem.Controls.Add(this.nTickWaitTime);
            this.GBSystem.Controls.Add(this.nSideSize);
            this.GBSystem.Controls.Add(this.TBSideSize);
            this.GBSystem.Location = new System.Drawing.Point(12, 286);
            this.GBSystem.Name = "GBSystem";
            this.GBSystem.Size = new System.Drawing.Size(355, 138);
            this.GBSystem.TabIndex = 13;
            this.GBSystem.TabStop = false;
            // 
            // lMaxHealthPreys
            // 
            this.lMaxHealthPreys.AutoSize = true;
            this.lMaxHealthPreys.Location = new System.Drawing.Point(3, 19);
            this.lMaxHealthPreys.Name = "lMaxHealthPreys";
            this.lMaxHealthPreys.Size = new System.Drawing.Size(33, 13);
            this.lMaxHealthPreys.TabIndex = 12;
            this.lMaxHealthPreys.Text = "Preys";
            // 
            // bColorPreys
            // 
            this.bColorPreys.BackColor = System.Drawing.Color.Lime;
            this.bColorPreys.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bColorPreys.ForeColor = System.Drawing.SystemColors.ControlText;
            this.bColorPreys.Location = new System.Drawing.Point(292, 435);
            this.bColorPreys.Name = "bColorPreys";
            this.bColorPreys.Size = new System.Drawing.Size(75, 23);
            this.bColorPreys.TabIndex = 14;
            this.bColorPreys.UseVisualStyleBackColor = false;
            this.bColorPreys.BackColorChanged += new System.EventHandler(this.bColorPreys_BackColorChanged);
            this.bColorPreys.Click += new System.EventHandler(this.bColorPreys_Click);
            // 
            // bColorPredators
            // 
            this.bColorPredators.BackColor = System.Drawing.Color.Red;
            this.bColorPredators.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bColorPredators.ForeColor = System.Drawing.SystemColors.ControlText;
            this.bColorPredators.Location = new System.Drawing.Point(292, 464);
            this.bColorPredators.Name = "bColorPredators";
            this.bColorPredators.Size = new System.Drawing.Size(75, 23);
            this.bColorPredators.TabIndex = 15;
            this.bColorPredators.UseVisualStyleBackColor = false;
            this.bColorPredators.BackColorChanged += new System.EventHandler(this.bColorPredators_BackColorChanged);
            this.bColorPredators.Click += new System.EventHandler(this.bColorPredators_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(188, 440);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 13);
            this.label1.TabIndex = 16;
            this.label1.Text = "Change prey\'s color:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(169, 469);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(122, 13);
            this.label3.TabIndex = 17;
            this.label3.Text = "Change predator\'s color:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(158, 498);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(133, 13);
            this.label4.TabIndex = 19;
            this.label4.Text = "Change background color:";
            // 
            // bColorBackground
            // 
            this.bColorBackground.BackColor = System.Drawing.Color.Red;
            this.bColorBackground.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bColorBackground.ForeColor = System.Drawing.SystemColors.ControlText;
            this.bColorBackground.Location = new System.Drawing.Point(292, 493);
            this.bColorBackground.Name = "bColorBackground";
            this.bColorBackground.Size = new System.Drawing.Size(75, 23);
            this.bColorBackground.TabIndex = 18;
            this.bColorBackground.UseVisualStyleBackColor = false;
            this.bColorBackground.BackColorChanged += new System.EventHandler(this.bColorBackground_BackColorChanged);
            this.bColorBackground.Click += new System.EventHandler(this.bColorBackground_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(381, 530);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.bColorBackground);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bColorPredators);
            this.Controls.Add(this.bColorPreys);
            this.Controls.Add(this.GBSystem);
            this.Controls.Add(this.GBMaxHealth);
            this.Controls.Add(this.bGenNew);
            this.Controls.Add(this.GBHealth);
            this.Controls.Add(this.bPause);
            this.Controls.Add(this.bPlay);
            this.Name = "Form1";
            this.Text = "Predators and Preys - Settings";
            ((System.ComponentModel.ISupportInitialize)(this.TBSideSize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nSideSize)).EndInit();
            this.GBHealth.ResumeLayout(false);
            this.GBHealth.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nHealthPreys)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TBHealthPreys)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nHealthPredators)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TBHealthPredators)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nTickWaitTime)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TBTickWaitTime)).EndInit();
            this.GBMaxHealth.ResumeLayout(false);
            this.GBMaxHealth.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nMaxHealthPredators)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TBMaxHealthPredators)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nMaxHealthPreys)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TBMaxHealthPreys)).EndInit();
            this.GBSystem.ResumeLayout(false);
            this.GBSystem.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bPlay;
        private System.Windows.Forms.Button bPause;
        private System.Windows.Forms.TrackBar TBSideSize;
        private System.Windows.Forms.Label lSideSize;
        private System.Windows.Forms.NumericUpDown nSideSize;
        private System.Windows.Forms.GroupBox GBHealth;
        private System.Windows.Forms.NumericUpDown nHealthPredators;
        private System.Windows.Forms.TrackBar TBHealthPredators;
        private System.Windows.Forms.Label lHealthPredators;
        private System.Windows.Forms.NumericUpDown nHealthPreys;
        private System.Windows.Forms.TrackBar TBHealthPreys;
        private System.Windows.Forms.Label lHealthPreys;
        private System.Windows.Forms.Button bGenNew;
        private System.Windows.Forms.NumericUpDown nTickWaitTime;
        private System.Windows.Forms.Label lTickWaitTime;
        private System.Windows.Forms.TrackBar TBTickWaitTime;
        private System.Windows.Forms.GroupBox GBMaxHealth;
        private System.Windows.Forms.Label lMaxHealthPreys;
        private System.Windows.Forms.NumericUpDown nMaxHealthPredators;
        private System.Windows.Forms.TrackBar TBMaxHealthPredators;
        private System.Windows.Forms.Label lMaxHealthPredators;
        private System.Windows.Forms.NumericUpDown nMaxHealthPreys;
        private System.Windows.Forms.TrackBar TBMaxHealthPreys;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox GBSystem;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Button bColorPreys;
        private System.Windows.Forms.Button bColorPredators;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button bColorBackground;
    }
}

