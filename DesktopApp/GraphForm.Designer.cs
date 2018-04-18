namespace DesktopApp
{
    partial class GraphForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GraphForm));
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.graphTimer = new System.Windows.Forms.Timer(this.components);
            this.leftPanel = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btnFHN1 = new System.Windows.Forms.Button();
            this.centerPanel = new System.Windows.Forms.Panel();
            this.lblC = new System.Windows.Forms.Label();
            this.lblV_Stim = new System.Windows.Forms.Label();
            this.lblGamma = new System.Windows.Forms.Label();
            this.lblBeta = new System.Windows.Forms.Label();
            this.lblGK = new System.Windows.Forms.Label();
            this.lblGNA = new System.Windows.Forms.Label();
            this.trackC = new System.Windows.Forms.TrackBar();
            this.labelC = new System.Windows.Forms.Label();
            this.labelVStim = new System.Windows.Forms.Label();
            this.labelGamma = new System.Windows.Forms.Label();
            this.labelBeta = new System.Windows.Forms.Label();
            this.trackV_STIM = new System.Windows.Forms.TrackBar();
            this.trackGAMMA = new System.Windows.Forms.TrackBar();
            this.trackBETA = new System.Windows.Forms.TrackBar();
            this.labelGK = new System.Windows.Forms.Label();
            this.labelGNA = new System.Windows.Forms.Label();
            this.trackGK = new System.Windows.Forms.TrackBar();
            this.trackGNA = new System.Windows.Forms.TrackBar();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.lineChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.leftPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.centerPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackV_STIM)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackGAMMA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBETA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackGK)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackGNA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lineChart)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // graphTimer
            // 
            this.graphTimer.Interval = 1;
            this.graphTimer.Tick += new System.EventHandler(this.graphTimer_Tick);
            // 
            // leftPanel
            // 
            this.leftPanel.Controls.Add(this.pictureBox1);
            this.leftPanel.Controls.Add(this.button4);
            this.leftPanel.Controls.Add(this.button3);
            this.leftPanel.Controls.Add(this.button2);
            this.leftPanel.Controls.Add(this.btnFHN1);
            this.leftPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.leftPanel.Location = new System.Drawing.Point(0, 24);
            this.leftPanel.Name = "leftPanel";
            this.leftPanel.Size = new System.Drawing.Size(270, 603);
            this.leftPanel.TabIndex = 21;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(31, 31);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(225, 225);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 40;
            this.pictureBox1.TabStop = false;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.button4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.button4.Location = new System.Drawing.Point(51, 474);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(172, 23);
            this.button4.TabIndex = 3;
            this.button4.Text = "SOO Model";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.button3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.button3.Location = new System.Drawing.Point(51, 412);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(172, 23);
            this.button3.TabIndex = 2;
            this.button3.Text = "SO Model";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.button2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.button2.Location = new System.Drawing.Point(51, 344);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(172, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "EULER Model";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // btnFHN1
            // 
            this.btnFHN1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnFHN1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnFHN1.Location = new System.Drawing.Point(51, 278);
            this.btnFHN1.Name = "btnFHN1";
            this.btnFHN1.Size = new System.Drawing.Size(172, 23);
            this.btnFHN1.TabIndex = 0;
            this.btnFHN1.Text = "FHN Model";
            this.btnFHN1.UseVisualStyleBackColor = false;
            this.btnFHN1.Click += new System.EventHandler(this.btnFHN1_Click);
            // 
            // centerPanel
            // 
            this.centerPanel.Controls.Add(this.lblC);
            this.centerPanel.Controls.Add(this.lblV_Stim);
            this.centerPanel.Controls.Add(this.lblGamma);
            this.centerPanel.Controls.Add(this.lblBeta);
            this.centerPanel.Controls.Add(this.lblGK);
            this.centerPanel.Controls.Add(this.lblGNA);
            this.centerPanel.Controls.Add(this.trackC);
            this.centerPanel.Controls.Add(this.labelC);
            this.centerPanel.Controls.Add(this.labelVStim);
            this.centerPanel.Controls.Add(this.labelGamma);
            this.centerPanel.Controls.Add(this.labelBeta);
            this.centerPanel.Controls.Add(this.trackV_STIM);
            this.centerPanel.Controls.Add(this.trackGAMMA);
            this.centerPanel.Controls.Add(this.trackBETA);
            this.centerPanel.Controls.Add(this.labelGK);
            this.centerPanel.Controls.Add(this.labelGNA);
            this.centerPanel.Controls.Add(this.trackGK);
            this.centerPanel.Controls.Add(this.trackGNA);
            this.centerPanel.Controls.Add(this.btnCalculate);
            this.centerPanel.Controls.Add(this.lineChart);
            this.centerPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.centerPanel.Location = new System.Drawing.Point(270, 24);
            this.centerPanel.Name = "centerPanel";
            this.centerPanel.Size = new System.Drawing.Size(1006, 603);
            this.centerPanel.TabIndex = 22;
            // 
            // lblC
            // 
            this.lblC.AutoSize = true;
            this.lblC.Location = new System.Drawing.Point(75, 343);
            this.lblC.Name = "lblC";
            this.lblC.Size = new System.Drawing.Size(40, 13);
            this.lblC.TabIndex = 39;
            this.lblC.Text = "(0.025)";
            // 
            // lblV_Stim
            // 
            this.lblV_Stim.AutoSize = true;
            this.lblV_Stim.Location = new System.Drawing.Point(75, 277);
            this.lblV_Stim.Name = "lblV_Stim";
            this.lblV_Stim.Size = new System.Drawing.Size(34, 13);
            this.lblV_Stim.TabIndex = 38;
            this.lblV_Stim.Text = "(0.90)";
            // 
            // lblGamma
            // 
            this.lblGamma.AutoSize = true;
            this.lblGamma.Location = new System.Drawing.Point(75, 211);
            this.lblGamma.Name = "lblGamma";
            this.lblGamma.Size = new System.Drawing.Size(34, 13);
            this.lblGamma.TabIndex = 37;
            this.lblGamma.Text = "(1.00)";
            // 
            // lblBeta
            // 
            this.lblBeta.AutoSize = true;
            this.lblBeta.Location = new System.Drawing.Point(75, 147);
            this.lblBeta.Name = "lblBeta";
            this.lblBeta.Size = new System.Drawing.Size(34, 13);
            this.lblBeta.TabIndex = 36;
            this.lblBeta.Text = "(0.06)";
            // 
            // lblGK
            // 
            this.lblGK.AutoSize = true;
            this.lblGK.Location = new System.Drawing.Point(75, 80);
            this.lblGK.Name = "lblGK";
            this.lblGK.Size = new System.Drawing.Size(34, 13);
            this.lblGK.TabIndex = 35;
            this.lblGK.Text = "(1.10)";
            // 
            // lblGNA
            // 
            this.lblGNA.AutoSize = true;
            this.lblGNA.Location = new System.Drawing.Point(75, 13);
            this.lblGNA.Name = "lblGNA";
            this.lblGNA.Size = new System.Drawing.Size(34, 13);
            this.lblGNA.TabIndex = 34;
            this.lblGNA.Text = "(0.90)";
            // 
            // trackC
            // 
            this.trackC.Location = new System.Drawing.Point(12, 361);
            this.trackC.Maximum = 50;
            this.trackC.Name = "trackC";
            this.trackC.Size = new System.Drawing.Size(166, 45);
            this.trackC.TabIndex = 33;
            this.trackC.Value = 25;
            this.trackC.Scroll += new System.EventHandler(this.trackC_Scroll);
            // 
            // labelC
            // 
            this.labelC.AutoSize = true;
            this.labelC.Location = new System.Drawing.Point(12, 344);
            this.labelC.Name = "labelC";
            this.labelC.Size = new System.Drawing.Size(14, 13);
            this.labelC.TabIndex = 32;
            this.labelC.Text = "C";
            // 
            // labelVStim
            // 
            this.labelVStim.AutoSize = true;
            this.labelVStim.Location = new System.Drawing.Point(12, 278);
            this.labelVStim.Name = "labelVStim";
            this.labelVStim.Size = new System.Drawing.Size(37, 13);
            this.labelVStim.TabIndex = 31;
            this.labelVStim.Text = "V Stim";
            // 
            // labelGamma
            // 
            this.labelGamma.AutoSize = true;
            this.labelGamma.Location = new System.Drawing.Point(12, 212);
            this.labelGamma.Name = "labelGamma";
            this.labelGamma.Size = new System.Drawing.Size(43, 13);
            this.labelGamma.TabIndex = 30;
            this.labelGamma.Text = "Gamma";
            // 
            // labelBeta
            // 
            this.labelBeta.AutoSize = true;
            this.labelBeta.Location = new System.Drawing.Point(12, 146);
            this.labelBeta.Name = "labelBeta";
            this.labelBeta.Size = new System.Drawing.Size(29, 13);
            this.labelBeta.TabIndex = 29;
            this.labelBeta.Text = "Beta";
            // 
            // trackV_STIM
            // 
            this.trackV_STIM.Location = new System.Drawing.Point(12, 295);
            this.trackV_STIM.Maximum = 5000;
            this.trackV_STIM.Name = "trackV_STIM";
            this.trackV_STIM.Size = new System.Drawing.Size(166, 45);
            this.trackV_STIM.TabIndex = 28;
            this.trackV_STIM.Value = 900;
            this.trackV_STIM.Scroll += new System.EventHandler(this.trackV_STIM_Scroll);
            // 
            // trackGAMMA
            // 
            this.trackGAMMA.Location = new System.Drawing.Point(12, 229);
            this.trackGAMMA.Maximum = 2000;
            this.trackGAMMA.Name = "trackGAMMA";
            this.trackGAMMA.Size = new System.Drawing.Size(166, 45);
            this.trackGAMMA.TabIndex = 27;
            this.trackGAMMA.Value = 1000;
            this.trackGAMMA.Scroll += new System.EventHandler(this.trackGAMMA_Scroll);
            // 
            // trackBETA
            // 
            this.trackBETA.Location = new System.Drawing.Point(12, 163);
            this.trackBETA.Maximum = 1000;
            this.trackBETA.Name = "trackBETA";
            this.trackBETA.Size = new System.Drawing.Size(166, 45);
            this.trackBETA.TabIndex = 26;
            this.trackBETA.Value = 600;
            this.trackBETA.Scroll += new System.EventHandler(this.trackBETA_Scroll);
            // 
            // labelGK
            // 
            this.labelGK.AutoSize = true;
            this.labelGK.Location = new System.Drawing.Point(12, 80);
            this.labelGK.Name = "labelGK";
            this.labelGK.Size = new System.Drawing.Size(55, 13);
            this.labelGK.TabIndex = 25;
            this.labelGK.Text = "Potassium";
            // 
            // labelGNA
            // 
            this.labelGNA.AutoSize = true;
            this.labelGNA.Location = new System.Drawing.Point(12, 14);
            this.labelGNA.Name = "labelGNA";
            this.labelGNA.Size = new System.Drawing.Size(42, 13);
            this.labelGNA.TabIndex = 24;
            this.labelGNA.Text = "Sodium";
            // 
            // trackGK
            // 
            this.trackGK.Location = new System.Drawing.Point(12, 97);
            this.trackGK.Maximum = 10000;
            this.trackGK.Name = "trackGK";
            this.trackGK.Size = new System.Drawing.Size(166, 45);
            this.trackGK.TabIndex = 23;
            this.trackGK.Value = 1100;
            this.trackGK.Scroll += new System.EventHandler(this.trackGK_Scroll);
            // 
            // trackGNA
            // 
            this.trackGNA.Location = new System.Drawing.Point(12, 33);
            this.trackGNA.Maximum = 10000;
            this.trackGNA.Name = "trackGNA";
            this.trackGNA.Size = new System.Drawing.Size(166, 45);
            this.trackGNA.TabIndex = 22;
            this.trackGNA.Value = 900;
            this.trackGNA.Scroll += new System.EventHandler(this.trackGNA_Scroll);
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(43, 412);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(112, 31);
            this.btnCalculate.TabIndex = 21;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // lineChart
            // 
            chartArea1.AxisX.MajorGrid.LineWidth = 0;
            chartArea1.Name = "ChartArea1";
            this.lineChart.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.lineChart.Legends.Add(legend1);
            this.lineChart.Location = new System.Drawing.Point(189, 12);
            this.lineChart.Name = "lineChart";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.LabelForeColor = System.Drawing.Color.Turquoise;
            series1.Legend = "Legend1";
            series1.Name = "FHN2";
            this.lineChart.Series.Add(series1);
            this.lineChart.Size = new System.Drawing.Size(747, 485);
            this.lineChart.TabIndex = 20;
            this.lineChart.Text = "chart1";
            this.lineChart.Click += new System.EventHandler(this.lineChart_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1276, 24);
            this.menuStrip1.TabIndex = 24;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(270, 605);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1006, 22);
            this.statusStrip1.TabIndex = 25;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // GraphForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1276, 627);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.centerPanel);
            this.Controls.Add(this.leftPanel);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "GraphForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Brain Scholar";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.leftPanel.ResumeLayout(false);
            this.leftPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.centerPanel.ResumeLayout(false);
            this.centerPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackV_STIM)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackGAMMA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBETA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackGK)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackGNA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lineChart)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Timer graphTimer;
        private System.Windows.Forms.Panel leftPanel;
        private System.Windows.Forms.Panel centerPanel;
        private System.Windows.Forms.Label lblC;
        private System.Windows.Forms.Label lblV_Stim;
        private System.Windows.Forms.Label lblGamma;
        private System.Windows.Forms.Label lblBeta;
        private System.Windows.Forms.Label lblGK;
        private System.Windows.Forms.Label lblGNA;
        private System.Windows.Forms.TrackBar trackC;
        private System.Windows.Forms.Label labelC;
        private System.Windows.Forms.Label labelVStim;
        private System.Windows.Forms.Label labelGamma;
        private System.Windows.Forms.Label labelBeta;
        private System.Windows.Forms.TrackBar trackV_STIM;
        private System.Windows.Forms.TrackBar trackGAMMA;
        private System.Windows.Forms.TrackBar trackBETA;
        private System.Windows.Forms.Label labelGK;
        private System.Windows.Forms.Label labelGNA;
        private System.Windows.Forms.TrackBar trackGK;
        private System.Windows.Forms.TrackBar trackGNA;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.DataVisualization.Charting.Chart lineChart;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnFHN1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

