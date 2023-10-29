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

        public static double Ymaximum = 1.5;
        public static double Yminimum = -1.5;

        private void Form2_Load(object sender, EventArgs e)
        {
            string operation = Form1.operation;
            double result2 = Form1.result2;
            double number3 = Form1.number3;
            double number3_angles = number3;
            number3 = number3 * Math.PI/180;
            plot(operation, result2, number3, number3_angles);
        }

        public void plot(string operation, double result2, double number3, double number3_angles)
        {
            var chart1 = new Chart();
            string title = "";
            string PlotTitle = "";
            chart1.Series.Clear();
            chart1.ChartAreas.Add(new ChartArea());

            var series = new Series("Points");
            List<double> xPoints = new List<double>();
            List<double> yPoints = new List<double>();
            var seriesBefore = new Series("Smaller");
            var seriesAfter = new Series("Larger");

            for (double x = number3_angles - 290; x < number3_angles + 290; x += Math.PI )
            {
                switch (operation)
                {
                    case "sin":
                        xPoints.Add(x);
                        yPoints.Add(Math.Sin(x*Math.PI/180));
                        title = "sin(x)";
                        PlotTitle = "y = sin(x)";
                        break;
                    case "cos":
                        xPoints.Add(x);
                        yPoints.Add(Math.Cos(x*Math.PI/180));
                        title = "cos(x)";
                        PlotTitle = "y = cos(x)";
                        break;
                    case "tg":
                        title = "tg(x)";
                        PlotTitle = "y = tg(x)";
                        break;
                    case "ctg":
                        title = "ctg(x)";
                        PlotTitle = "y = ctg(x)";
                        break;
                    default:
                        break;
                }
            }

            if (operation == "sin" || operation == "cos")
            {
                series.Points.DataBindXY(xPoints, yPoints);
                chart1.Series.Add(series);
                series.ChartType = SeriesChartType.Line;

                var seriesPoint = new Series("Result");
                seriesPoint.Points.AddXY(number3_angles, result2);
                seriesPoint.ChartType = SeriesChartType.Point;
                chart1.Series.Add(seriesPoint);
                chart1.Series["Result"].MarkerSize = 5;
                chart1.Series["Result"].MarkerStyle = MarkerStyle.Circle;
                chart1.Series["Result"].CustomProperties = "IsXAxisQuantitative=True";
                chart1.Series["Result"].MarkerColor = Color.Red;

                var seriesLineX = new Series("Horizontal Line");
                seriesLineX.Points.AddXY(number3_angles - 290, result2);
                seriesLineX.Points.AddXY(number3_angles, result2);
                seriesLineX.ChartType = SeriesChartType.Line;
                chart1.Series.Add(seriesLineX);
                chart1.Series["Horizontal Line"].BorderWidth = 2;
                chart1.Series["Horizontal Line"].BorderDashStyle = ChartDashStyle.Dash;
                chart1.Series["Horizontal Line"].Color = Color.Red;

                var seriesLineY = new Series("Vertical Line");
                seriesLineY.Points.AddXY(number3_angles, Yminimum);
                seriesLineY.Points.AddXY(number3_angles, result2);
                seriesLineY.ChartType = SeriesChartType.Line;
                chart1.Series.Add(seriesLineY);
                chart1.Series["Vertical Line"].BorderWidth = 2;
                chart1.Series["Vertical Line"].BorderDashStyle = ChartDashStyle.Dash;
                chart1.Series["Vertical Line"].Color = Color.Red;

                chart1.Series["Points"].BorderWidth = 2;
                chart1.Location = new System.Drawing.Point(0, 0);
                chart1.Size = new System.Drawing.Size(600, 300);
                chart1.ChartAreas[0].AxisX.LabelStyle.Format = "0.00";
                chart1.ChartAreas[0].AxisX.Title = "x (degrees)";
                chart1.ChartAreas[0].AxisY.Title = title;

                chart1.ChartAreas[0].AxisY.Maximum = Ymaximum;
                chart1.ChartAreas[0].AxisY.Minimum = Yminimum;
                chart1.ChartAreas[0].AxisX.Maximum = number3_angles + 290;
                chart1.ChartAreas[0].AxisX.Minimum = number3_angles - 290;
                chart1.Titles.Add(PlotTitle);

                var MyDataPoint = new DataPoint(0, 0);

                var TextAnnotationX = new TextAnnotation();
                string number3Text = number3_angles.ToString("N2");
                TextAnnotationX.Text = number3Text;
                TextAnnotationX.AnchorDataPoint = MyDataPoint;
                TextAnnotationX.AxisX = chart1.ChartAreas[0].AxisX;
                TextAnnotationX.AxisY = chart1.ChartAreas[0].AxisY;
                TextAnnotationX.X = number3_angles;
                TextAnnotationX.Y = -1.2;
                TextAnnotationX.ForeColor = Color.Red;
                TextAnnotationX.Visible = true;
                chart1.Annotations.Add(TextAnnotationX);

                var TextAnnotationY = new TextAnnotation();
                string resultText = result2.ToString("N2");
                TextAnnotationY.Text = resultText;
                TextAnnotationY.AnchorDataPoint = MyDataPoint;
                TextAnnotationY.AxisX = chart1.ChartAreas[0].AxisX;
                TextAnnotationY.AxisY = chart1.ChartAreas[0].AxisY;
                TextAnnotationY.X = number3_angles - 290;
                TextAnnotationY.Y = result2;
                TextAnnotationY.ForeColor = Color.Red;
                TextAnnotationY.Visible = true;
                chart1.Annotations.Add(TextAnnotationY);

                this.Controls.Add(chart1);

                this.Controls.Add(chart1);
            }

            else if (operation == "ctg" || operation == "tg")
            {
                List<double> xPoints1 = new List<double>();
                List<double> yPoints1 = new List<double>();

                List<double> xPoints2 = new List<double>();
                List<double> yPoints2 = new List<double>();

                List<double> xPoints3 = new List<double>();
                List<double> yPoints3 = new List<double>();

                double start_x = 0;
                double end_x = 0;

                switch (operation)
                {
                    case "ctg":
                        start_x = Math.PI * ((int)(number3 / Math.PI));
                        end_x = start_x + Math.PI;

                        if (number3 < start_x)
                        {
                            start_x = start_x - Math.PI;
                            end_x = start_x + Math.PI;
                        }
                        else if (number3 > end_x)
                        {
                            start_x = end_x;
                            end_x = start_x + Math.PI;

                        }

                        for (double x = Math.Round(start_x, 4) + 0.001; x < end_x; x += Math.PI / 280)
                        {
                            xPoints1.Add(x);
                        }

                        foreach (double xPoint in xPoints1)
                        {
                            yPoints1.Add(1 / Math.Tan(xPoint));
                        }

                        for (double x = Math.Round(start_x, 4) - Math.PI + 0.0001; x < start_x; x += Math.PI / 280)
                        {
                            xPoints2.Add(x);
                        }

                        foreach (double xPoint in xPoints2)
                        {
                            yPoints2.Add(1 / Math.Tan(xPoint));
                        }

                        for (double x = Math.Round(start_x, 4) + Math.PI + 0.0001; x < end_x + Math.PI; x += Math.PI / 280)
                        {
                            xPoints3.Add(x);
                        }

                        foreach (double xPoint in xPoints3)
                        {
                            yPoints3.Add(1 / Math.Tan(xPoint));
                        }


                        break;
                    case "tg":
                        start_x = Math.PI * ((int)(number3 / Math.PI)) + Math.PI / 2;
                        end_x = start_x + Math.PI;

                        if (number3 < start_x)
                        {
                            start_x = start_x - Math.PI;
                            end_x = start_x + Math.PI;
                        }
                        else if (number3 > end_x)
                        {
                            start_x = end_x;
                            end_x = start_x + Math.PI;

                        }

                        for (double x = Math.Round(start_x, 4) + 0.001; x < end_x; x += Math.PI / 280)
                        {
                            xPoints1.Add(x);
                        }

                        foreach (double xPoint in xPoints1)
                        {
                            yPoints1.Add(Math.Tan(xPoint));
                        }

                        for (double x = Math.Round(start_x, 4) - Math.PI + 0.0001; x < start_x; x += Math.PI / 280)
                        {
                            xPoints2.Add(x);
                        }

                        foreach (double xPoint in xPoints2)
                        {
                            yPoints2.Add(Math.Tan(xPoint));
                        }

                        for (double x = Math.Round(start_x, 4) + Math.PI + 0.0001; x < end_x + Math.PI; x += Math.PI / 280)
                        {
                            xPoints3.Add(x);
                        }

                        foreach (double xPoint in xPoints3)
                        {
                            yPoints3.Add(Math.Tan(xPoint));
                        }

                        break;
                }

                List<double> xPoints1_angles = new List<double>();
                List<double> xPoints2_angles = new List<double>();
                List<double> xPoints3_angles = new List<double>();

                foreach (double xPoint in xPoints1)
                {
                    xPoints1_angles.Add(xPoint*180/Math.PI);
                }

                foreach (double xPoint in xPoints2)
                {
                    xPoints2_angles.Add(xPoint * 180 / Math.PI);
                }

                foreach (double xPoint in xPoints3)
                {
                    xPoints3_angles.Add(xPoint * 180 / Math.PI);
                }

                seriesBefore.Points.DataBindXY(xPoints2_angles, yPoints2);
                seriesAfter.Points.DataBindXY(xPoints3_angles, yPoints3);
                chart1.Series.Add(seriesBefore);
                seriesBefore.ChartType = SeriesChartType.Line;
                chart1.Series.Add(seriesAfter);
                seriesAfter.ChartType = SeriesChartType.Line;


                series.Points.DataBindXY(xPoints1_angles, yPoints1);
                chart1.Series.Add(series);
                series.ChartType = SeriesChartType.Line;

                var seriesPoint = new Series("Result");
                seriesPoint.Points.AddXY(number3_angles, result2);
                seriesPoint.ChartType = SeriesChartType.Point;
                chart1.Series.Add(seriesPoint);
                chart1.Series["Result"].MarkerSize = 5;
                chart1.Series["Result"].MarkerStyle = MarkerStyle.Circle;
                chart1.Series["Result"].CustomProperties = "IsXAxisQuantitative=True";
                chart1.Series["Result"].MarkerColor = Color.Red;

                var seriesLineX = new Series("Horizontal Line");
                seriesLineX.Points.AddXY(start_x*180/Math.PI - 180, result2);
                seriesLineX.Points.AddXY(number3_angles, result2);
                seriesLineX.ChartType = SeriesChartType.Line;
                chart1.Series.Add(seriesLineX);
                chart1.Series["Horizontal Line"].BorderWidth = 2;
                chart1.Series["Horizontal Line"].BorderDashStyle = ChartDashStyle.Dash;
                chart1.Series["Horizontal Line"].Color = Color.Red;

                var seriesLineY = new Series("Vertical Line");
                seriesLineY.Points.AddXY(number3_angles, -Math.Round(Math.Abs(result2)) - 10);
                seriesLineY.Points.AddXY(number3_angles, result2);
                seriesLineY.ChartType = SeriesChartType.Line;
                chart1.Series.Add(seriesLineY);
                chart1.Series["Vertical Line"].BorderWidth = 2;
                chart1.Series["Vertical Line"].BorderDashStyle = ChartDashStyle.Dash;
                chart1.Series["Vertical Line"].Color = Color.Red;

                chart1.Series["Points"].BorderWidth = 2;
                chart1.Series["Points"].Color = Color.MediumBlue;
                chart1.Series["Smaller"].Color = Color.MediumBlue;
                chart1.Series["Larger"].Color = Color.MediumBlue;
                chart1.Series["Smaller"].BorderWidth = 2;
                chart1.Series["Larger"].BorderWidth = 2;

                chart1.Location = new System.Drawing.Point(0, 0);
                chart1.Size = new System.Drawing.Size(600, 500);
                chart1.ChartAreas[0].AxisX.LabelStyle.Format = "0.00";
                chart1.ChartAreas[0].AxisX.Title = "x (degrees)";
                chart1.ChartAreas[0].AxisY.Title = title;

                chart1.ChartAreas[0].AxisY.Maximum = Math.Round(Math.Abs(result2))+10;
                chart1.ChartAreas[0].AxisY.Minimum = -Math.Round(Math.Abs(result2))-5;
                chart1.ChartAreas[0].AxisX.Maximum = end_x*180/Math.PI + 180;
                chart1.ChartAreas[0].AxisX.Minimum = start_x*180/Math.PI - 180;
                chart1.Titles.Add(PlotTitle);

                this.Controls.Add(chart1);

                var MyDataPoint = new DataPoint(0, 0);

                var TextAnnotationX = new TextAnnotation();
                string number3Text = number3_angles.ToString("N2");
                TextAnnotationX.Text = number3Text;
                TextAnnotationX.AnchorDataPoint = MyDataPoint;
                TextAnnotationX.AxisX = chart1.ChartAreas[0].AxisX;
                TextAnnotationX.AxisY = chart1.ChartAreas[0].AxisY;
                TextAnnotationX.X = number3_angles;
                TextAnnotationX.Y = -Math.Round(Math.Abs(result2))+5;
                TextAnnotationX.ForeColor = Color.Red;
                TextAnnotationX.Visible = true;
                chart1.Annotations.Add(TextAnnotationX);

                var TextAnnotationY = new TextAnnotation();
                string resultText = result2.ToString("N2");
                TextAnnotationY.Text = resultText;
                TextAnnotationY.AnchorDataPoint = MyDataPoint;
                TextAnnotationY.AxisX = chart1.ChartAreas[0].AxisX;
                TextAnnotationY.AxisY = chart1.ChartAreas[0].AxisY;
                TextAnnotationY.X = start_x*180/Math.PI - Math.PI;
                TextAnnotationY.Y = result2;
                TextAnnotationY.ForeColor = Color.Red;
                TextAnnotationY.Visible = true;
                chart1.Annotations.Add(TextAnnotationY);

                this.Controls.Add(chart1);
            }
        }
    }
}
