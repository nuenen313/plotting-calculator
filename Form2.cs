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
            plot(operation, result2, number3);
        }

        public void plot(string operation, double result2, double number3)
        {
            var chart1 = new Chart();
            string title = "";
            string PlotTitle = "";
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
                        title = "sin(x)";
                        PlotTitle = "y = sin(x)";
                        break;
                    case "cos":
                        yPoints.Add(Math.Cos(x));
                        title = "cos(x)";
                        PlotTitle = "y = cos(x)";
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
            chart1.Series["Result"].CustomProperties = "IsXAxisQuantitative=True";
            chart1.Series["Result"].MarkerColor = Color.Red;

            var seriesLineX = new Series("Horizontal Line");
            seriesLineX.Points.AddXY(number3-5, result2);
            seriesLineX.Points.AddXY(number3, result2);
            seriesLineX.ChartType = SeriesChartType.Line;
            chart1.Series.Add(seriesLineX);
            chart1.Series["Horizontal Line"].BorderWidth = 2;
            chart1.Series["Horizontal Line"].BorderDashStyle = ChartDashStyle.Dash;
            chart1.Series["Horizontal Line"].Color = Color.Red;

            var seriesLineY = new Series("Vertical Line");
            seriesLineY.Points.AddXY(number3, Yminimum);
            seriesLineY.Points.AddXY(number3, result2);
            seriesLineY.ChartType = SeriesChartType.Line;
            chart1.Series.Add(seriesLineY);
            chart1.Series["Vertical Line"].BorderWidth = 2;
            chart1.Series["Vertical Line"].BorderDashStyle = ChartDashStyle.Dash;
            chart1.Series["Vertical Line"].Color = Color.Red;

            chart1.Series["Points"].BorderWidth = 2;
            chart1.Location = new System.Drawing.Point(0, 0);
            chart1.Size = new System.Drawing.Size(600, 300);
            chart1.ChartAreas[0].AxisX.LabelStyle.Format = "0.00";
            chart1.ChartAreas[0].AxisX.Title = "x";
            chart1.ChartAreas[0].AxisY.Title = title;

            chart1.ChartAreas[0].AxisY.Maximum = Ymaximum;
            chart1.ChartAreas[0].AxisY.Minimum = Yminimum;
            chart1.ChartAreas[0].AxisX.Maximum = number3 + 5;
            chart1.ChartAreas[0].AxisX.Minimum = number3 - 5;
            chart1.Titles.Add(PlotTitle);

            var MyDataPoint = new DataPoint(0,0);

            var TextAnnotationX = new TextAnnotation();
            string number3Text = number3.ToString("N2");
            TextAnnotationX.Text = number3Text;
            TextAnnotationX.AnchorDataPoint = MyDataPoint;
            TextAnnotationX.AxisX = chart1.ChartAreas[0].AxisX;
            TextAnnotationX.AxisY = chart1.ChartAreas[0].AxisY;
            TextAnnotationX.X = number3;
            TextAnnotationX.Y = -1.5;
            TextAnnotationX.ForeColor = Color.Red;
            TextAnnotationX.Visible = true;
            chart1.Annotations.Add(TextAnnotationX);

            var TextAnnotationY = new TextAnnotation();
            string resultText = result2.ToString("N2");
            TextAnnotationY.Text = resultText;
            TextAnnotationY.AnchorDataPoint = MyDataPoint;
            TextAnnotationY.AxisX = chart1.ChartAreas[0].AxisX;
            TextAnnotationY.AxisY = chart1.ChartAreas[0].AxisY;
            TextAnnotationY.X = number3-5;
            TextAnnotationY.Y = result2;
            TextAnnotationY.ForeColor = Color.Red;
            TextAnnotationY.Visible = true;
            chart1.Annotations.Add(TextAnnotationY);

            this.Controls.Add(chart1);

        }
    }
}
