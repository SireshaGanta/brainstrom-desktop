using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DesktopApp
{
    public partial class GraphForm : Form
    {
        GraphData g = new GraphData();

        int iteration;
        public GraphForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            centerPanel.Visible = false;
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            double dtt = Convert.ToDouble(trackGNA.Value * 1.00 / 100);

            g.lineChart = lineChart;
            g.InitializeChart();
            iteration = 0;
            graphTimer.Start();
        }

        private void graphTimer_Tick(object sender, EventArgs e)
        {
            double gna = Convert.ToDouble((trackGNA.Value*1.00) / 1000);
            double gk = Convert.ToDouble((trackGK.Value * 1.00) / 1000);
            double beta = Convert.ToDouble((trackBETA.Value * 1.00) / 1000);
            double gamma = Convert.ToDouble((trackGAMMA.Value * 1.00) / 1000);
            double v_stim = Convert.ToDouble((trackV_STIM.Value * 1.00) / 1000);
            double c = Convert.ToDouble((trackC.Value * 1.00) / 1000);


            g.SetVariables(gna, gk, beta, gamma, v_stim, c);
            g.Calculate(iteration);
            iteration++;
            //g.TestData();
        }

        private void trackGNA_Scroll(object sender, EventArgs e)
        {
            double gna = Convert.ToDouble((trackGNA.Value * 1.00) / 1000);
            lblGNA.Text = "(" + gna.ToString() + ")";
        }

        private void trackGK_Scroll(object sender, EventArgs e)
        {
            double gk = Convert.ToDouble((trackGK.Value * 1.00) / 1000);
            lblGK.Text = "(" + gk.ToString() + ")";
        }

        private void trackBETA_Scroll(object sender, EventArgs e)
        {
            double beta = Convert.ToDouble((trackBETA.Value * 1.00) / 1000);
            lblBeta.Text = "(" + beta.ToString() + ")";
        }

        private void trackGAMMA_Scroll(object sender, EventArgs e)
        {
            double gamma = Convert.ToDouble((trackGAMMA.Value * 1.00) / 1000);
            lblGamma.Text = "(" + gamma.ToString() + ")";
        }

        private void trackV_STIM_Scroll(object sender, EventArgs e)
        {
            double v_stim = Convert.ToDouble((trackV_STIM.Value * 1.00) / 1000);
            lblV_Stim.Text = "(" + v_stim.ToString() + ")";
        }

        private void trackC_Scroll(object sender, EventArgs e)
        {
            double c = Convert.ToDouble((trackC.Value * 1.00) / 1000);
            lblC.Text = "(" + c.ToString() + ")";
        }

 
 


        private void btnFHN1_Click(object sender, EventArgs e)
        {
            tutorialform form = new tutorialform();
            var x = form.ShowDialog();
            centerPanel.Visible = true;
            
        }

        private void lineChart_Click(object sender, EventArgs e)
        {

        }
    }
}
