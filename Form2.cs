using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
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
        public static string text = "";

        private void Form2_Load(object sender, EventArgs e)
        {
            string operation = Form1.operation;
            string operation2 = Form3.operation;
            if (operation2 == "quad")
            {
                operation = operation2;
            }
            double result2 = Form1.result2;
            double number3 = Form1.number3;
            double number3_angles = number3;
            double a = Form3.a;
            double b = Form3.b;
            double c = Form3.c;
            number3 = number3 * Math.PI/180;
            text = plot(operation, result2, number3, number3_angles, a, b, c, text);
        }

        public string plot(string operation, double result2, double number3, double number3_angles, double a, double b, double c, string text)
        {
            string title = "";
            string PlotTitle = "";


            List<double> xPoints = new List<double>();
            List<double> yPoints = new List<double>();
            var seriesBefore = new Series("Smaller");
            var seriesAfter = new Series("Larger");

            switch (operation)
            {
                case "sin":
                    for (double x = number3_angles - 290; x < number3_angles + 290; x += Math.PI)
                    {
                        xPoints.Add(x);
                        yPoints.Add(Math.Sin(x * Math.PI / 180));
                    }
                    title = "sin(x)";
                    PlotTitle = "y = sin(x)";
                    break;
                case "cos":
                    for (double x = number3_angles - 290; x < number3_angles + 290; x += Math.PI)
                    {
                        xPoints.Add(x);
                        yPoints.Add(Math.Cos(x * Math.PI / 180));
                    }
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
                case "quad":
                    text = plot_quadratic(a, b, c);
                    break;
                default:
                    break;
            }

            if (operation == "sin" || operation == "cos")
            {
                plot_sin_cos(xPoints, yPoints, number3_angles, result2, title, PlotTitle);
            }

            else if (operation == "ctg" || operation == "tg")
            {
                plot_tan_cot(xPoints, yPoints, number3_angles, result2, title, PlotTitle, operation, number3);
            }

            return text;
        }

        public void plot_sin_cos(List<double> xPoints, List<double> yPoints, double number3_angles, double result2, string title, string PlotTitle)
        {
            var chart1 = new Chart();
            chart1.Series.Clear();
            chart1.ChartAreas.Add(new ChartArea());
            var series = new Series("Points");

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
            chart1.ChartAreas[0].AxisX.LabelStyle.Format = "0.";
            chart1.ChartAreas[0].AxisX.Title = "x (degrees)";
            chart1.ChartAreas[0].AxisY.Title = title;

            chart1.ChartAreas[0].AxisY.Maximum = Ymaximum;
            chart1.ChartAreas[0].AxisY.Minimum = Yminimum;
            chart1.ChartAreas[0].AxisX.Maximum = number3_angles + 290;
            chart1.ChartAreas[0].AxisX.Minimum = number3_angles - 290;

            Title title0 = new Title();
            title0.Font = new Font("Century Gothic", 12, FontStyle.Regular);
            title0.Text = PlotTitle;
            chart1.Titles.Add(title0);
            chart1.ChartAreas[0].AxisX.LabelStyle.Font = new Font("Century Gothic", 10, FontStyle.Regular);
            chart1.ChartAreas[0].AxisY.LabelStyle.Font = new Font("Century Gothic", 10, FontStyle.Regular);
            chart1.ChartAreas[0].AxisX.TitleFont = new Font("Century Gothic", 11, FontStyle.Regular);
            chart1.ChartAreas[0].AxisY.TitleFont = new Font("Century Gothic", 11, FontStyle.Regular);

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
            TextAnnotationX.Font = new Font("Century Gothic", 11, FontStyle.Regular);
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
            TextAnnotationY.Font = new Font("Century Gothic", 11, FontStyle.Regular);
            chart1.Annotations.Add(TextAnnotationY);

            var seriesXAxis = new Series("XAxis");
            var seriesYAxis = new Series("YAxis");

            seriesXAxis.Points.AddXY(xPoints.Min(), 0);
            seriesXAxis.Points.AddXY(xPoints.Max(), 0);
            seriesXAxis.ChartType = SeriesChartType.Line;
            seriesXAxis.Color = Color.Black;
            chart1.Series.Add(seriesXAxis);

            seriesYAxis.Points.AddXY(0, Math.Round(yPoints.Max()) + 50);
            seriesYAxis.Points.AddXY(0, Math.Round(yPoints.Min()) - 50);
            seriesYAxis.ChartType = SeriesChartType.Line;
            seriesYAxis.Color = Color.Black;
            chart1.Series.Add(seriesYAxis);

            chart1.ChartAreas[0].AxisX.MajorGrid.LineColor = Color.LightGray;
            chart1.ChartAreas[0].AxisY.MajorGrid.LineColor = Color.LightGray;
            chart1.ChartAreas[0].AxisX.LineColor = Color.LightGray;
            chart1.ChartAreas[0].AxisY.LineColor = Color.LightGray;

            this.Controls.Add(chart1);
        }

        public void plot_tan_cot(List<double> xPoints, List<double> yPoints, double number3_angles, double result2, string title, string PlotTitle, string operation, double number3)
        {
            var chart1 = new Chart();
            chart1.Series.Clear();
            chart1.ChartAreas.Add(new ChartArea());
            var series = new Series("Points");
            var seriesBefore = new Series("Smaller");
            var seriesAfter = new Series("Larger");

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

                    for (double x = Math.Round(start_x, 4) + 0.001; x < end_x; x += Math.PI / 4000)
                    {
                        xPoints1.Add(x);
                    }

                    foreach (double xPoint in xPoints1)
                    {
                        yPoints1.Add(1 / Math.Tan(xPoint));
                    }

                    for (double x = Math.Round(start_x, 4) - Math.PI + 0.0001; x < start_x; x += Math.PI / 4000)
                    {
                        xPoints2.Add(x);
                    }

                    foreach (double xPoint in xPoints2)
                    {
                        yPoints2.Add(1 / Math.Tan(xPoint));
                    }

                    for (double x = Math.Round(start_x, 4) + Math.PI + 0.0001; x < end_x + Math.PI; x += Math.PI / 4000)
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

                    for (double x = Math.Round(start_x, 4) + 0.001; x < end_x; x += Math.PI / 4000)
                    {
                        xPoints1.Add(x);
                    }

                    foreach (double xPoint in xPoints1)
                    {
                        yPoints1.Add(Math.Tan(xPoint));
                    }

                    for (double x = Math.Round(start_x, 4) - Math.PI + 0.0001; x < start_x; x += Math.PI / 4000)
                    {
                        xPoints2.Add(x);
                    }

                    foreach (double xPoint in xPoints2)
                    {
                        yPoints2.Add(Math.Tan(xPoint));
                    }

                    for (double x = Math.Round(start_x, 4) + Math.PI + 0.0001; x < end_x + Math.PI; x += Math.PI / 4000)
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
                xPoints1_angles.Add(xPoint * 180 / Math.PI);
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
            seriesLineX.Points.AddXY(start_x * 180 / Math.PI - 180, result2);
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
            chart1.Series["Points"].Color = Color.RoyalBlue;
            chart1.Series["Smaller"].Color = Color.RoyalBlue;
            chart1.Series["Larger"].Color = Color.RoyalBlue;
            chart1.Series["Smaller"].BorderWidth = 2;
            chart1.Series["Larger"].BorderWidth = 2;

            chart1.Location = new System.Drawing.Point(0, 0);
            chart1.Size = new System.Drawing.Size(600, 500);
            chart1.ChartAreas[0].AxisX.LabelStyle.Format = "0.";
            chart1.ChartAreas[0].AxisX.Title = "x (degrees)";
            chart1.ChartAreas[0].AxisX.TitleFont = new Font("Century Gothic", 11, FontStyle.Regular);
            chart1.ChartAreas[0].AxisY.TitleFont = new Font("Century Gothic", 11, FontStyle.Regular);
            Title title_x = new Title();
            chart1.ChartAreas[0].AxisY.Title = title;


            chart1.ChartAreas[0].AxisY.Maximum = Math.Round(Math.Abs(result2)) + 10;
            chart1.ChartAreas[0].AxisY.Minimum = -Math.Round(Math.Abs(result2)) - 5;
            chart1.ChartAreas[0].AxisX.Maximum = end_x * 180 / Math.PI + 180;
            chart1.ChartAreas[0].AxisX.Minimum = start_x * 180 / Math.PI - 180;
            Title title1 = new Title();
            title1.Font = new Font("Century Gothic", 12, FontStyle.Regular);
            title1.Text = PlotTitle;
            chart1.Titles.Add(title1);
            chart1.ChartAreas[0].AxisX.LabelStyle.Font = new Font("Century Gothic", 10, FontStyle.Regular);
            chart1.ChartAreas[0].AxisY.LabelStyle.Font = new Font("Century Gothic", 10, FontStyle.Regular);

            this.Controls.Add(chart1);

            var MyDataPoint = new DataPoint(0, 0);

            var TextAnnotationX = new TextAnnotation();
            string number3Text = number3_angles.ToString("N2");
            TextAnnotationX.Text = number3Text;
            TextAnnotationX.AnchorDataPoint = MyDataPoint;
            TextAnnotationX.AxisX = chart1.ChartAreas[0].AxisX;
            TextAnnotationX.AxisY = chart1.ChartAreas[0].AxisY;
            TextAnnotationX.X = number3_angles;
            TextAnnotationX.Y = -Math.Round(Math.Abs(result2)) - 3;
            TextAnnotationX.ForeColor = Color.Red;
            TextAnnotationX.Visible = true;
            TextAnnotationX.Font = new Font("Century Gothic", 11, FontStyle.Regular);
            chart1.Annotations.Add(TextAnnotationX);

            var TextAnnotationY = new TextAnnotation();
            string resultText = result2.ToString("N2");
            TextAnnotationY.Text = resultText;
            TextAnnotationY.AnchorDataPoint = MyDataPoint;
            TextAnnotationY.AxisX = chart1.ChartAreas[0].AxisX;
            TextAnnotationY.AxisY = chart1.ChartAreas[0].AxisY;
            TextAnnotationY.X = start_x * 180 / Math.PI - 180;
            TextAnnotationY.Y = result2;
            TextAnnotationY.ForeColor = Color.Red;
            TextAnnotationY.Visible = true;
            TextAnnotationY.Font = new Font("Century Gothic", 11, FontStyle.Regular);
            chart1.Annotations.Add(TextAnnotationY);

            var seriesXAxis = new Series("XAxis");
            var seriesYAxis = new Series("YAxis");

            seriesXAxis.Points.AddXY(start_x * 180 / Math.PI - 350, 0);
            seriesXAxis.Points.AddXY(end_x * 180 / Math.PI + 350, 0);
            seriesXAxis.ChartType = SeriesChartType.Line;
            seriesXAxis.Color = Color.Black;
            chart1.Series.Add(seriesXAxis);

            seriesYAxis.Points.AddXY(0, Math.Round(Math.Abs(result2)) + 50);
            seriesYAxis.Points.AddXY(0, -Math.Round(Math.Abs(result2)) - 50);
            seriesYAxis.ChartType = SeriesChartType.Line;
            seriesYAxis.Color = Color.Black;
            chart1.Series.Add(seriesYAxis);

            chart1.ChartAreas[0].AxisX.MajorGrid.LineColor = Color.LightGray;
            chart1.ChartAreas[0].AxisY.MajorGrid.LineColor = Color.LightGray;
            chart1.ChartAreas[0].AxisX.LineColor = Color.LightGray;
            chart1.ChartAreas[0].AxisY.LineColor = Color.LightGray;

            this.Controls.Add(chart1);

        }

        public string plot_quadratic(double a, double b, double c)
        {
            string text;
            var chart1 = new Chart();
            string a_string = a.ToString("N2");
            string b_string = b.ToString("N2");
            string c_string = c.ToString("N2");
            string PlotTitle = "";
            if (c >= 0 && b >= 0)
            {
                PlotTitle = "y = " + a_string + "x^2 + " + b_string + "x + " + c_string;
            }
            else if (c >= 0 && b < 0)
            {
                PlotTitle = "y = " + a_string + "x^2 " + b_string + "x + " + c_string;
            }
            else if (c < 0 && b >= 0)
            {
                PlotTitle = "y = " + a_string + "x^2 + " + b_string + "x " + c_string;
            }
            else if (c < 0 && b < 0)
            {
                PlotTitle = "y = " + a_string + "x^2 " + b_string + "x " + c_string;
            }
            else
            {
                PlotTitle = "y = " + a_string + "x^2 + " + b_string + "x + " + c_string;
            }
            chart1.Series.Clear();
            chart1.ChartAreas.Add(new ChartArea());
            chart1.ChartAreas[0].AxisX.MajorGrid.LineColor = Color.LightGray;
            chart1.ChartAreas[0].AxisY.MajorGrid.LineColor = Color.LightGray;


            double delta = (b * b) - 4 * a * c;
            double xLimMax;
            double xLimMin;

            var seriesQuadratic = new Series("Quadratic");
            List<double> xValues = new List<double>();
            List<double> yValues = new List<double>();

            var seriesAnswer0 = new Series("Answer0");
            var seriesAnswer1 = new Series("Answer1");
            var seriesAnswer2 = new Series("Answer2");

            var MyDataPoint = new DataPoint(0, 0);

            if (delta < 0)
            {
                for (double x = -10; x <= 10; x += 0.1)
                {
                    xValues.Add(x);
                    yValues.Add(a * x * x + b * x + c);
                }
                xLimMax = 10;
                xLimMin = -10;

                text = "No real roots";

            }
            else if (delta == 0)
            {
                double answer0 = (-1)*b/(2*a);
                for (double x = Math.Round(answer0) - 20; x <= Math.Round(answer0) + 20; x += 0.1)
                {
                    xValues.Add(x);
                    yValues.Add(a * x * x + b * x + c);
                }
                xLimMax = Math.Round(xValues.Max() + 10);
                xLimMin = Math.Round(xValues.Min() - 10);

                seriesAnswer0.Points.AddXY(answer0, 0);
                seriesAnswer0.ChartType = SeriesChartType.Point;
                chart1.Series.Add(seriesAnswer0);
                chart1.Series["Answer0"].MarkerSize = 5;
                chart1.Series["Answer0"].MarkerStyle = MarkerStyle.Circle;
                chart1.Series["Answer0"].CustomProperties = "IsXAxisQuantitative=True";
                chart1.Series["Answer0"].MarkerColor = Color.Red;

                var TextAnnotation0 = new TextAnnotation();
                string answer0Text = answer0.ToString("N2");
                TextAnnotation0.Text = answer0Text;
                TextAnnotation0.AnchorDataPoint = MyDataPoint;
                TextAnnotation0.AxisX = chart1.ChartAreas[0].AxisX;
                TextAnnotation0.AxisY = chart1.ChartAreas[0].AxisY;
                TextAnnotation0.X = answer0;
                TextAnnotation0.Y = -5;
                TextAnnotation0.ForeColor = Color.Red;
                TextAnnotation0.Visible = true;
                TextAnnotation0.Font = new Font("Century Gothic", 11, FontStyle.Regular);
                chart1.Annotations.Add(TextAnnotation0);

                text = "Root: " + answer0Text;

            }
            else
            {
                double answer1 = ((-1) * b + Math.Sqrt(delta)) / (2 * a);
                double answer2 = ((-1) * b - Math.Sqrt(delta)) / (2 * a);
                double bigger;
                double smaller;
                if (answer1 > answer2)
                {
                    bigger = answer1;
                    smaller = answer2;
                }
                else
                {
                    bigger = answer2;
                    smaller = answer1;
                }
                for (double x = Math.Round(smaller) - 10; x <= Math.Round(bigger) + 10; x += 0.1)
                {
                    xValues.Add(x);
                    yValues.Add(a * x * x + b * x + c);
                }
                double mean = ((answer1 + answer2) / 2);
                xLimMax = Math.Round(bigger) + 10;
                xLimMin = Math.Round(smaller) - 10;

                seriesAnswer1.Points.AddXY(answer1, 0);
                seriesAnswer1.ChartType = SeriesChartType.Point;
                chart1.Series.Add(seriesAnswer1);
                chart1.Series["Answer1"].MarkerSize = 5;
                chart1.Series["Answer1"].MarkerStyle = MarkerStyle.Circle;
                chart1.Series["Answer1"].CustomProperties = "IsXAxisQuantitative=True";
                chart1.Series["Answer1"].MarkerColor = Color.Red;

                seriesAnswer2.Points.AddXY(answer2, 0);
                seriesAnswer2.ChartType = SeriesChartType.Point;
                chart1.Series.Add(seriesAnswer2);
                chart1.Series["Answer2"].MarkerSize = 5;
                chart1.Series["Answer2"].MarkerStyle = MarkerStyle.Circle;
                chart1.Series["Answer2"].CustomProperties = "IsXAxisQuantitative=True";
                chart1.Series["Answer2"].MarkerColor = Color.Red;

                var TextAnnotation1 = new TextAnnotation();
                string answer1Text = answer1.ToString("N2");
                TextAnnotation1.Text = answer1Text;
                TextAnnotation1.AnchorDataPoint = MyDataPoint;
                TextAnnotation1.AxisX = chart1.ChartAreas[0].AxisX;
                TextAnnotation1.AxisY = chart1.ChartAreas[0].AxisY;
                TextAnnotation1.X = answer1;
                TextAnnotation1.Y = -5;
                TextAnnotation1.ForeColor = Color.Red;
                TextAnnotation1.Visible = true;
                TextAnnotation1.Font = new Font("Century Gothic", 11, FontStyle.Regular);
                chart1.Annotations.Add(TextAnnotation1);

                var TextAnnotation2 = new TextAnnotation();
                string answer2Text = answer2.ToString("N2");
                TextAnnotation2.Text = answer2Text;
                TextAnnotation2.AnchorDataPoint = MyDataPoint;
                TextAnnotation2.AxisX = chart1.ChartAreas[0].AxisX;
                TextAnnotation2.AxisY = chart1.ChartAreas[0].AxisY;
                TextAnnotation2.X = answer2;
                TextAnnotation2.Y = -5;
                TextAnnotation2.ForeColor = Color.Red;
                TextAnnotation2.Visible = true;
                TextAnnotation2.Font = new Font("Century Gothic", 11, FontStyle.Regular);
                chart1.Annotations.Add(TextAnnotation2);

                text = "Root 1: " + answer1Text + ", root 2: " + answer2Text;

                //yLim = Math.Round(yValues.Min()) - 50;

            }

            var seriesXAxis = new Series("XAxis");
            var seriesYAxis = new Series("YAxis");

            seriesXAxis.Points.AddXY(xValues.Min(), 0);
            seriesXAxis.Points.AddXY(xValues.Max(), 0);
            seriesXAxis.ChartType = SeriesChartType.Line;
            seriesXAxis.Color = Color.Black;
            chart1.Series.Add(seriesXAxis);

            seriesYAxis.Points.AddXY(0, Math.Round(yValues.Max())+100000);
            seriesYAxis.Points.AddXY(0, Math.Round(yValues.Min())-100000);
            seriesYAxis.ChartType = SeriesChartType.Line;
            seriesYAxis.Color = Color.Black;
            chart1.Series.Add(seriesYAxis);

            seriesQuadratic.Points.DataBindXY(xValues, yValues);
            chart1.Series.Add(seriesQuadratic);
            chart1.Series["Quadratic"].Color = Color.RoyalBlue;
            seriesQuadratic.ChartType = SeriesChartType.Line;

            chart1.Location = new System.Drawing.Point(0, 0);
            chart1.Size = new System.Drawing.Size(600, 600);
            chart1.ChartAreas[0].AxisX.LabelStyle.Format = "0.";
            chart1.ChartAreas[0].AxisX.Title = "x";
            chart1.ChartAreas[0].AxisY.Title = "y";
            Title title = new Title();
            title.Font = new Font("Century Gothic", 12, FontStyle.Regular);
            title.Text = PlotTitle;
            chart1.Titles.Add(title);
            chart1.ChartAreas[0].AxisX.LabelStyle.Font = new Font("Century Gothic", 10, FontStyle.Regular);
            chart1.ChartAreas[0].AxisY.LabelStyle.Font = new Font("Century Gothic", 10, FontStyle.Regular);
            chart1.ChartAreas[0].AxisX.TitleFont = new Font("Century Gothic", 11, FontStyle.Regular);
            chart1.ChartAreas[0].AxisY.TitleFont = new Font("Century Gothic", 11, FontStyle.Regular);

            chart1.ChartAreas[0].AxisY.Minimum = Math.Round(yValues.Min())-10;
            chart1.ChartAreas[0].AxisY.Maximum = Math.Round(yValues.Max())+50;
            chart1.ChartAreas[0].AxisX.Maximum = xLimMax;
            chart1.ChartAreas[0].AxisX.Minimum = xLimMin;
            chart1.ChartAreas[0].AxisX.LineColor = Color.LightGray;
            chart1.ChartAreas[0].AxisY.LineColor = Color.LightGray;

            this.Controls.Add(chart1);

            return text;
        }
    }
}
