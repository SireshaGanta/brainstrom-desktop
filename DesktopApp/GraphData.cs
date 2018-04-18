using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesktopApp
{
    public class GraphData
    {
        public System.Windows.Forms.DataVisualization.Charting.Chart lineChart { get; set; }

        //Limit
        public int XUpperBoundary { get; set; }
        public int XLowerBoundary { get; set; }
        public int YUpperBoundary { get; set; }
        public int YLowerBoundary { get; set; }

        public int TickLimit { get; set; }

        private double[] f = new double[10000];
        private double[] u = new double[10000];
        private double[] v = new double[10000];

        public double GNA  = 5, GK = 6, BETA = 10, GAMMA = 5, V_STIM = 9, C = 3;

        private const double del_t = 0.001;
        private int cl = 30;
        private int T ;
        private Double num ;
        

        public GraphData()
        {
            XUpperBoundary = 10000;
            XLowerBoundary = 0;

            YLowerBoundary = -100;
            YUpperBoundary = 20;

            TickLimit = 10;

        }

        public void InitializeChart()
        {
            cl = 30;
             T = cl * 4;
            num = T / del_t;
            u[0] = -1.1;
            v[0] = -1.2;

            lineChart.ChartAreas[0].AxisX.Maximum = XUpperBoundary;
            lineChart.ChartAreas[0].AxisX.Minimum = XLowerBoundary;

            lineChart.ChartAreas[0].AxisY.Maximum = YUpperBoundary;
            lineChart.ChartAreas[0].AxisY.Minimum = YLowerBoundary;
        }

        public void SetVariables(double gna, double gk, double beta, double gamma, double v_stim, double c)
        {
            GNA = gna;
            GK = gk;
            BETA = beta;
            GAMMA = gamma;
            V_STIM = v_stim;
            C = c;
        }

        public void Calculate(int iteration)
        {
                Double floor = iteration / 3000;
                double stinum = Math.Floor(floor);
                Double stimt = 3000 + 3000 * (stinum - 1);
                int intstim = Convert.ToInt32(stimt);

                f[iteration % 6000] = v[iteration % 6000] * (1 - ((v[iteration % 6000] * v[iteration % 6000]) / 3));
                v[(iteration + 1) % 6000] = 1 / C * (GNA * f[iteration % 6000] - GK * u[iteration % 6000]) * del_t + v[iteration % 6000];
                if (intstim == iteration)
                {
                    v[(iteration + 1) % 6000] = v[(iteration + 1) % 6000] + V_STIM;
                }
                u[(iteration + 1) % 6000] = (v[iteration % 6000] + BETA - GAMMA * u[iteration % 6000]) * del_t + u[iteration % 6000];
                double currentMin = -2.2, currentMax = 2.2, minScaled = -90, maxScaled = 10, scaledValue;
                scaledValue = (maxScaled - minScaled) * (v[iteration % 6000] - currentMin) / (currentMax - currentMin) + minScaled;

                lineChart.Series["FHN2"].Points.AddXY(iteration, scaledValue);
                
                if (iteration > 10001)
                {
                    //After we reach 10000 iterations, it will remove the earliest data point with each new one
                    lineChart.Series["FHN2"].Points.RemoveAt(0);
                }
                if (iteration > 10000)
                {
                    //We adjust the viewport with every new point
                    lineChart.ChartAreas[0].AxisX.Maximum = lineChart.ChartAreas[0].AxisX.Maximum +1;
                    lineChart.ChartAreas[0].AxisX.Minimum = lineChart.ChartAreas[0].AxisX.Minimum +1;

                }
            
            

        }

    }
}
