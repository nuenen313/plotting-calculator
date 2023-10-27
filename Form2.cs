using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace calculate
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        //variables
        public static double Ymaximum = 1.5;
        public static double Yminimum = -1.5;

        private void Form2_Load(object sender, EventArgs e)
        {
            string operation = Form1.operation;
            double result2 = Form1.result2;
            double number3 = Form1.number3;
            plotPlot(operation, result2, number3);
        }

        public void plotPlot(string operation, double result2, double number3)
        {
            var chart1 = new Chart();
            chart1.Series.Clear();
            chart1.ChartAreas.Add(new ChartArea());

            var series = new Series("Points");
            List<double> xPoints = new List<double>();
            List<double> yPoints = new List<double>();
            for (double x = number3 - 5; x < number3 + 5; x += Math.PI / 180)
            {
                xPoints.Add(x);
                switch (operation)
                {
                    case "sin":
                        yPoints.Add(Math.Sin(x));
                        break;
                    case "cos":
                        yPoints.Add(Math.Cos(x));
                        break;
                    default:
                        break;
                }
            }
            series.Points.DataBindXY(xPoints, yPoints);
            chart1.Series.Add(series);
            series.ChartType = SeriesChartType.Line;

            var seriesPoint = new Series("Result");
            seriesPoint.Points.AddXY(number3, result2);
            seriesPoint.ChartType = SeriesChartType.Point;
            chart1.Series.Add(seriesPoint);
            chart1.Series["Result"].MarkerSize = 5;
            chart1.Series["Result"].MarkerStyle = MarkerStyle.Circle;
            chart1.Series["Result"].MarkerColor = Color.Red;

            chart1.Location = new System.Drawing.Point(0, 0);
            chart1.Size = new System.Drawing.Size(600, 300);
            chart1.ChartAreas[0].AxisX.LabelStyle.Format = "0.00";
            chart1.ChartAreas[0].AxisY.Maximum = Ymaximum;
            chart1.ChartAreas[0].AxisY.Minimum = Yminimum;
            chart1.ChartAreas[0].AxisX.Maximum = number3 + 5;
            chart1.ChartAreas[0].AxisX.Minimum = number3 - 5;

            this.Controls.Add(chart1);
            
        }
    }
}
