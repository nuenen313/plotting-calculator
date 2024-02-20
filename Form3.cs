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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace calculate
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        public static double a;
        public static double b;
        public static double c;
        public static string operation;

        private void textBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Shift && e.KeyCode == Keys.OemPeriod)
            {
                e.SuppressKeyPress = true;
            }
            if (!(e.KeyCode >= Keys.D0 && e.KeyCode <= Keys.D9 || e.KeyCode == Keys.OemPeriod || e.KeyCode == Keys.Back || e.KeyCode == Keys.OemMinus))
            {
                e.SuppressKeyPress = true;
            }
            else if (textBox_a.Text.Contains('.') && (e.KeyCode == Keys.OemPeriod || e.KeyCode == Keys.OemMinus))
            {
                e.SuppressKeyPress = true;
            }
            else if (textBox_a.Text.Contains('-') && e.KeyCode == Keys.OemMinus)
            {
                e.SuppressKeyPress = true;
            }
            else if (textBox_a.Text.Length > 0 && textBox_a.Text[0] != '-' && e.KeyCode == Keys.OemMinus)
            {
                e.SuppressKeyPress = true;
            }
        }

        private void textBox_b_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Shift && e.KeyCode == Keys.OemPeriod)
            {
                e.SuppressKeyPress = true;
            }
            if (!(e.KeyCode >= Keys.D0 && e.KeyCode <= Keys.D9 || e.KeyCode == Keys.OemPeriod || e.KeyCode == Keys.Back || e.KeyCode == Keys.OemMinus))
            {
                e.SuppressKeyPress = true;
            }
            else if (textBox_b.Text.Contains('.') && (e.KeyCode == Keys.OemPeriod || e.KeyCode == Keys.OemMinus))
            {
                e.SuppressKeyPress = true;
            }
            else if (textBox_b.Text.Contains('-') && e.KeyCode == Keys.OemMinus)
            {
                e.SuppressKeyPress = true;
            }
            else if (textBox_b.Text.Length > 0 && textBox_b.Text[0] != '-' && e.KeyCode == Keys.OemMinus)
            {
                e.SuppressKeyPress = true;
            }
        }

        private void textBox_c_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Shift && e.KeyCode == Keys.OemPeriod || e.Shift && e.KeyCode == Keys.OemMinus)
            {
                e.SuppressKeyPress = true;
            }
            if (!(e.KeyCode >= Keys.D0 && e.KeyCode <= Keys.D9 || e.KeyCode == Keys.OemPeriod || e.KeyCode == Keys.Back || e.KeyCode == Keys.OemMinus))
            {
                e.SuppressKeyPress = true;
            }
            else if (textBox_c.Text.Contains('.') && (e.KeyCode == Keys.OemPeriod || e.KeyCode==Keys.OemMinus))
            {
                e.SuppressKeyPress = true;
            }
            else if (textBox_c.Text.Contains('-') && e.KeyCode == Keys.OemMinus)
            {
                e.SuppressKeyPress = true;
            }
            else if (textBox_c.Text.Length > 0 && textBox_c.Text[0] != '-' && e.KeyCode == Keys.OemMinus)
            {
                e.SuppressKeyPress = true;
            }
        }

        private void button_quadratic_Click(object sender, EventArgs e)
        {
            if (textBox_a.Text.Length > 20 || textBox_b.Text.Length > 20 || textBox_c.Text.Length > 20)
            {
                textEditor.Text = "Value is too large to compute";
            }
            else
            {
                textEditor.ReadOnly = false;
                operation = "quad";
                if (textBox_a.Text.Length > 0)
                {
                    if (textBox_a.Text == "-" || textBox_a.Text == ".")
                    {
                       a = 0;
                    }
                    else
                    {
                        a = double.Parse(textBox_a.Text);
                    }
                }
                else
                {
                    a = 0;
                }
                if (textBox_b.Text.Length > 0)
                {
                    if (textBox_b.Text == "-" || textBox_b.Text == ".")
                    {
                        b = 0;
                    }
                    else
                    {
                        b = double.Parse(textBox_b.Text);
                    }
                }
                else
                {
                    b = 0;
                }
                if (textBox_c.Text.Length > 0)
                {
                    if (textBox_c.Text == "-" || textBox_c.Text == ".")
                    {
                        c = 0;
                    }
                    else
                    {
                        c = double.Parse(textBox_c.Text);
                    }
                }
                else
                {
                    c = 0;
                }
                compute();
            }
        }

        public void compute()
        {
            if (a == 0)
            {
                textEditor.Text = "Input any non-zero value for a to calculate roots";
                textEditor.ReadOnly = true;
            }
            else
            {
                operation = "quad";
                plot();
                string text = Form2.text;
                textEditor.Text = text;
                operation = "none";
            }
        }

        public void plot()
        {
            Form2 plottingForm = new Form2();
            plottingForm.Show();
        }

        private void textBox_a_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox_b_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox_c_TextChanged(object sender, EventArgs e)
        {

        }

        public void textEditor_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
