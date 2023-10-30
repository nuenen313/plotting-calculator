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
using static System.Net.Mime.MediaTypeNames;

namespace calculate
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        float number1;
        float number2;
        public static double number3;
        public static double result2;
        public static string operation;
        float result;

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (!(e.KeyCode >= Keys.D0 && e.KeyCode <= Keys.D9 || e.KeyCode == Keys.Back))
            {
                e.SuppressKeyPress = true;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            textEditor.Text = textEditor.Text + "1";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textEditor.Text = textEditor.Text + "2";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textEditor.Text = textEditor.Text + "3";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textEditor.Text = textEditor.Text + "4";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textEditor.Text = textEditor.Text + "5";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textEditor.Text = textEditor.Text + "6";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textEditor.Text = textEditor.Text + "7";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textEditor.Text = textEditor.Text + "8";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textEditor.Text = textEditor.Text + "9";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            textEditor.Text = textEditor.Text + "0";
        }

        private void button_pi_Click(object sender, EventArgs e)
        {
            check_E();
            if (textEditor.Text.Length > 30)
            {
                textEditor.Text = "Value is too large to compute";
                disableButtons();
            }
            else
            {
                if (textEditor.Text.Length > 0 && !(textEditor.Text.Contains('+') || textEditor.Text.Contains('-') || textEditor.Text.Contains('×') || textEditor.Text.Contains('÷')))
                {
                    textEditor.Text = (Math.PI).ToString();
                }
                else
                {
                    textEditor.Text = textEditor.Text + (Math.PI).ToString();
                }
            }
        }

        private void button_e_Click(object sender, EventArgs e)
        {
            check_E();
            if (textEditor.Text.Length > 30)
            {
                textEditor.Text = "Value is too large to compute";
                disableButtons();
            }
            else
            {
                if (textEditor.Text.Length > 0 && !(textEditor.Text.Contains('+') || textEditor.Text.Contains('-') || textEditor.Text.Contains('×') || textEditor.Text.Contains('÷')))
                {
                    textEditor.Text = (Math.E).ToString();
                }
                else
                {
                    textEditor.Text = textEditor.Text + (Math.E).ToString();
                }
            }
        }

        private void button_comma_Click(object sender, EventArgs e)
        {
            check_E();
            if (textEditor.Text.Length > 30)
            {
                textEditor.Text = "Value is too large to compute";
                disableButtons();
            }
            else
            {
                string text = textEditor.Text;
                if (text.Length == 0)
                {
                    textEditor.AppendText("0,");
                }
                else
                {
                    char lastCharacter = text[text.Length - 1];
                    int commaCount = 0;
                    foreach (char c in text)
                    {
                        if (c == ',')
                        {
                            commaCount++;
                        }
                    }
                    if (lastCharacter == '+' || lastCharacter == '-' || lastCharacter == '×' || lastCharacter == '÷')
                    {
                        textEditor.AppendText("0,");
                    }
                    else if (text.EndsWith(","))
                    {

                    }
                    else if (text.Contains(","))
                    {
                        if ((text.Contains("+") || text.Contains("-") || text.Contains("×") || text.Contains("÷")))
                        {
                            char op = Convert.ToChar(operation);
                            string last_number = text.Split(op).Last();

                            if (last_number.Contains(','))
                            {
                                textEditor.AppendText("");
                            }
                            else
                            {
                                textEditor.AppendText(",");
                            }
                        }
                        else
                        {
                            textEditor.AppendText("");
                        }
                    }
                    else
                    {
                        textEditor.AppendText(",");
                    }
                }
            }
        }

        private void button_add_Click(object sender, EventArgs e)
        {
            check_E();
            if (textEditor.Text.Length > 30)
            {
                textEditor.Text = "Value is too large to compute";
                disableButtons();
            }
            else
            {
                if (textEditor.Text.Length > 0)
                {
                    string text = textEditor.Text;
                    char lastElement = text[text.Length - 1];
                    if (lastElement == '+' || lastElement == '-' || lastElement == '×' || lastElement == '÷')
                    {
                        text = text.Remove(text.Length - 1);
                        textEditor.Text = text;
                    }
                    if (textEditor.Text.Length == 0)
                    {
                        number1 = 0;
                    }
                    else
                    {
                        if (text.Contains("+") || text.Contains("-") || text.Contains("×") || text.Contains("÷"))
                        {
                            button_equals.PerformClick();
                        }
                        number1 = float.Parse(textEditor.Text);
                    }
                }
                else
                {
                    number1 = 0;
                }
                operation = "+";
                textEditor.AppendText("+");
            }
        }

        private void button_subtract_Click(object sender, EventArgs e)
        {
            check_E();
            if (textEditor.Text.Length > 30)
            {
                textEditor.Text = "Value is too large to compute";
                disableButtons();
            }
            else
            {
                if (textEditor.Text.Length > 0)
                {
                    string text = textEditor.Text;
                    char lastElement = text[text.Length - 1];
                    if (lastElement == '+' || lastElement == '-' || lastElement == '×' || lastElement == '÷')
                    {
                        text = text.Remove(text.Length - 1);
                        textEditor.Text = text;
                    }
                    if (textEditor.Text.Length == 0)
                    {
                        number1 = 0;
                    }
                    else
                    {
                        if (text.Contains("+") || text.Contains("-") || text.Contains("×") || text.Contains("÷"))
                        {
                            button_equals.PerformClick();
                        }
                        number1 = float.Parse(textEditor.Text);
                    }
                }
                else
                {
                    number1 = 0;
                }
                operation = "-";
                textEditor.AppendText("-");
            }
        }

        private void button_multiply_Click(object sender, EventArgs e)
        {
            check_E();
            if (textEditor.Text.Length > 30)
            {
                textEditor.Text = "Value is too large to compute";
                disableButtons();
            }
            else
            {
                if (textEditor.Text.Length > 0)
                {
                    string text = textEditor.Text;
                    char lastElement = text[text.Length - 1];
                    if (lastElement == '+' || lastElement == '-' || lastElement == '×' || lastElement == '÷')
                    {
                        text = text.Remove(text.Length - 1);
                        textEditor.Text = text;
                    }
                    if (textEditor.Text.Length == 0)
                    {
                        number1 = 0;
                    }
                    else
                    {
                        if (text.Contains("+") || text.Contains("-") || text.Contains("×") || text.Contains("÷"))
                        {
                            button_equals.PerformClick();
                        }
                        number1 = float.Parse(textEditor.Text);
                    }
                }
                else
                {
                    number1 = 0;
                }
                operation = "×";
                textEditor.AppendText("×");
            }
        }

        private void button_divide_Click(object sender, EventArgs e)
        {
            check_E();
            if (textEditor.Text.Length > 30)
            {
                textEditor.Text = "Value is too large to compute";
                disableButtons();
            }
            else
            {
                if (textEditor.Text.Length > 0)
                {
                    string text = textEditor.Text;
                    char lastElement = text[text.Length - 1];
                    if (lastElement == '+' || lastElement == '-' || lastElement == '×' || lastElement == '÷')
                    {
                        text = text.Remove(text.Length - 1);
                        textEditor.Text = text;
                    }
                    if (textEditor.Text.Length == 0)
                    {
                        number1 = 0;
                    }
                    else
                    {
                        if (text.Contains("+") || text.Contains("-") || text.Contains("×") || text.Contains("÷"))
                        {
                            button_equals.PerformClick();
                        }
                        number1 = float.Parse(textEditor.Text);
                    }
                }
                else
                {
                    number1 = 0;
                }
                operation = "÷";
                textEditor.AppendText("÷");
            }
        }

        private void button_sin_Click(object sender, EventArgs e)
        {
            check_E();
            if (textEditor.Text.Length > 30)
            {
                textEditor.Text = "Value is too large to compute";
                disableButtons();
            }
            else
            {
                if (textEditor.Text.Length > 0)
                {
                    string text = textEditor.Text;
                    char lastElement = text[text.Length - 1];
                    if (text.Contains('+') || text.Contains('-') || text.Contains('×') || text.Contains('÷'))
                    {
                        trigonometric_function("sin", lastElement, text);
                    }
                    if (textEditor.Text.Length == 0)
                    {
                        number3 = 0;
                    }
                    else
                    {
                        number3 = double.Parse(textEditor.Text);
                    }
                    textEditor.Text = "sin(" + Convert.ToString(number3) + ")";
                    textEditor.ReadOnly = true;
                    disableButtons();
                }
            }
        }

        private void button_cos_Click(object sender, EventArgs e) 
        {
            check_E();
            if (textEditor.Text.Length > 30)
            {
                textEditor.Text = "Value is too large to compute";
                disableButtons();
            }
            else
            {
                if (textEditor.Text.Length > 0)
                {
                    string text = textEditor.Text;
                    char lastElement = text[text.Length - 1];
                    if (text.Contains('+') || text.Contains('-') || text.Contains('×') || text.Contains('÷'))
                    {
                        trigonometric_function("cos", lastElement, text);
                    }
                    if (textEditor.Text.Length == 0)
                    {
                        number3 = 0;
                    }
                    else
                    {
                        number3 = double.Parse(textEditor.Text);
                    }
                    textEditor.Text = "cos(" + Convert.ToString(number3) + ")";
                    textEditor.ReadOnly = true;
                    textEditor.ReadOnly = true;
                    disableButtons();
                }
            }
        }

        private void button_tg_Click(object sender, EventArgs e)
        {
            check_E();
            if (textEditor.Text.Length > 30)
            {
                textEditor.Text = "Value is too large to compute";
                disableButtons();
            }
            else
            {
                if (textEditor.Text.Length > 0)
                {
                    operation = "tg";
                    string text = textEditor.Text;
                    char lastElement = text[text.Length - 1];
                    if (text.Contains('+') || text.Contains('-') || text.Contains('×') || text.Contains('÷'))
                    {
                        trigonometric_function("tg", lastElement, text);
                    }
                    if (textEditor.Text.Length == 0)
                    {
                        number3 = 0;
                    }
                    else
                    {
                        number3 = double.Parse(textEditor.Text);
                    }
                    textEditor.Text = "tg(" + Convert.ToString(number3) + ")";
                    textEditor.ReadOnly = true;
                    disableButtons();
                }
            }
        }

        private void button_ctg_Click(object sender, EventArgs e)
        {
            check_E();
            if (textEditor.Text.Length > 30)
            {
                textEditor.Text = "Value is too large to compute";
                disableButtons();
            }
            else
            {
                if (textEditor.Text.Length > 0)
                {
                    operation = "ctg";
                    string text = textEditor.Text;
                    char lastElement = text[text.Length - 1];
                    if (text.Contains('+') || text.Contains('-') || text.Contains('×') || text.Contains('÷'))
                    {
                        trigonometric_function("ctg", lastElement, text);
                    }
                    if (textEditor.Text.Length == 0)
                    {
                        number3 = 0;
                    }
                    else
                    {
                        number3 = double.Parse(textEditor.Text);
                    }
                    textEditor.Text = "ctg(" + Convert.ToString(number3) + ")";
                    textEditor.ReadOnly = true;
                    disableButtons();
                }
            }
        }

        private void button_equals_Click(object sender, EventArgs e)
        {
            check_E();
            if (textEditor.Text.Length > 30)
            {
                textEditor.Text = "Value is too large to compute";
                disableButtons();
            }
            else
            {
                textEditor.ReadOnly = false;
                enableButtons();
                string total = textEditor.Text;
                if (operation == null)
                {
                    operation = "none";
                    number1 = float.Parse(total);
                }

                if (!(operation == "sin" || operation == "cos" || operation == "none" || operation == "rad" || operation == "tg" || operation == "ctg"))
                {
                    char op = Convert.ToChar(operation);
                    string num2 = total.Split(op).Last();
                    if (num2.Length > 0)
                    {
                        number2 = float.Parse(num2);
                    }
                    else
                    {
                        number2 = 0;
                    }
                }

                textEditor.Clear();
                compute(operation);
                number1 = 0;
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            check_E();
            if (textEditor.Text.Length > 30)
            {
                textEditor.Text = "Value is too large to compute";
                disableButtons();
            }
            else
            {
                string text = textEditor.Text;
                if (text.Contains('+') || text.Contains('×') || text.Contains('s') || text.Contains('÷'))
                {
                }
                else if (text.StartsWith("-"))
                {
                    text = text.Remove(0, 1);
                    textEditor.Text = text;
                }
                else if (text.Contains('-'))
                {
                }
                else
                {
                    textEditor.Text = "-" + text;
                }
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            Form3 equationForm = new Form3();
            equationForm.Show();
        }

        private void button_clear_Click(object sender, EventArgs e)
        {
            textEditor.Clear();
            textEditor.ReadOnly = false;
            enableButtons();
        }

        private void button_backspace_Click(object sender, EventArgs e)
        {
            check_E();
            if (textEditor.Text.Length > 30)
            {
                textEditor.Text = "Value is too large to compute";
                disableButtons();
            }
            else
            {
                int textLength = textEditor.Text.Length;
                string text = textEditor.Text;
                if (textLength > 0)
                {
                    text = text.Remove(textLength - 1);
                }
                textEditor.Text = text;
            }
        }

        private void disableButtons()
        {
            Button1.Enabled = false;
            Button2.Enabled = false;
            Button3.Enabled = false;
            Button4.Enabled = false;
            Button5.Enabled = false;
            Button6.Enabled = false;
            Button7.Enabled = false;
            Button8.Enabled = false;
            Button9.Enabled = false;
            Button10.Enabled = false;
            button11.Enabled = false;
            button_comma.Enabled = false;
            button_add.Enabled = false;
            button_subtract.Enabled = false;
            button_multiply.Enabled = false;
            button_divide.Enabled = false;
            button_backspace.Enabled = false;
            button_cos.Enabled = false;
            button_sin.Enabled = false;
            button_pi.Enabled = false;
            button_e.Enabled = false;
            button_tg.Enabled = false;
            button_ctg.Enabled = false;
        }

        private void enableButtons()
        {
            Button1.Enabled = true;
            Button2.Enabled = true;
            Button3.Enabled = true;
            Button4.Enabled = true;
            Button5.Enabled = true;
            Button6.Enabled = true;
            Button7.Enabled = true;
            Button8.Enabled = true;
            Button9.Enabled = true;
            Button10.Enabled = true;
            button11.Enabled = true;
            button_comma.Enabled = true;
            button_add.Enabled = true;
            button_subtract.Enabled = true;
            button_multiply.Enabled = true;
            button_divide.Enabled = true;
            button_backspace.Enabled = true;
            button_sin.Enabled = true;
            button_cos.Enabled = true;
            button_pi.Enabled = true;
            button_e.Enabled = true;
            button_tg.Enabled = true;
            button_ctg.Enabled = true;
        }

        public void compute(string operation)
        {
            check_E();
            switch (operation)
            {
                case "+":
                    result = number1 + number2;
                    textEditor.Text = result.ToString();
                    break;
                case "-":
                    result = number1 - number2;
                    textEditor.Text = result.ToString();
                    break;
                case "×":
                    result = number1 * number2;
                    textEditor.Text = result.ToString();
                    break;
                case "÷":
                    if (number2 == 0)
                    {
                        textEditor.Text = "";
                        number3 = number1;
                        break;
                    }
                    else
                    {
                        result = number1 / number2;
                        textEditor.Text = result.ToString();
                    }
                    break;
                case "sin":
                    result2 = Math.Sin(number3 * Math.PI / 180);
                    textEditor.Text = result2.ToString();
                    plot();
                    break;
                case "cos":
                    result2 = Math.Cos(number3 * Math.PI / 180);
                    textEditor.Text= result2.ToString();
                    plot();
                    break;
                case "tg":
                    if (number3%90 == 0)
                    {
                        textEditor.Text = "x value out of the function domain";
                        textEditor.ReadOnly = true;
                        disableButtons();
                    }
                    else
                    {
                        result2 = Math.Round(Math.Tan(number3 * Math.PI / 180), 10);
                        textEditor.Text = result2.ToString();
                        plot();
                    }
                    break;
                case "ctg":
                    if (number3%180 == 0 || number3 == 0)
                    {
                        textEditor.Text = "x value out of the function domain";
                        textEditor.ReadOnly = true;
                        disableButtons();
                    }
                    else
                    {
                        result2 = Math.Round(1 / Math.Tan(number3 * Math.PI / 180), 10);
                        textEditor.Text = result2.ToString();
                        plot();
                    }
                    break;
                case "none":
                    result = number1;
                    textEditor.Text = result.ToString();
                    break;
                default:
                    break;
            }
        }

        public void plot()
        {
            Form2 plottingForm = new Form2();
            plottingForm.Show();
        }

        private void check_E()
        {
            if (textEditor.Text.Contains('E'))
            {
                disableButtons();
            }
        }

        private void trigonometric_function(string operation1, char lastElement, string text)
        {
            if (lastElement == '+' || lastElement == '-' || lastElement == '×' || lastElement == '÷')
            {
                text = text.Remove(text.Length - 1);
                textEditor.Text = text;
            }
            if (text.Contains('+'))
            {
                operation = "+";
                char op = Convert.ToChar(operation);
                string last_number = text.Split(op).Last();
                number2 = (float)Convert.ToDouble(last_number);
                compute(operation);
                number3 = double.Parse(textEditor.Text);
                operation = operation1;
                string last_number2 = textEditor.Text.Split(op).Last();
                number2 = (float)Convert.ToDouble(last_number2);
            }
            if (text.Contains('-'))
            {
                operation = "-";
                char op = Convert.ToChar(operation);
                string last_number = text.Split(op).Last();
                number2 = (float)Convert.ToDouble(last_number);
                compute(operation);
                number3 = double.Parse(textEditor.Text);
                operation = operation1;
                string last_number2 = textEditor.Text.Split(op).Last();
                number2 = (float)Convert.ToDouble(last_number2);
            }
            if (text.Contains('×'))
            {
                operation = "×";
                char op = Convert.ToChar(operation);
                string last_number = text.Split(op).Last();
                number2 = (float)Convert.ToDouble(last_number);
                compute(operation);
                number3 = double.Parse(textEditor.Text);
                operation = operation1;
                string last_number2 = textEditor.Text.Split(op).Last();
                number2 = (float)Convert.ToDouble(last_number2);
            }
            if (text.Contains('÷'))
            {
                operation = "÷";
                char op = Convert.ToChar(operation);
                string last_number = text.Split(op).Last();
                number2 = (float)Convert.ToDouble(last_number);
                if (number2 - 0 < float.Epsilon)
                {
                    textEditor.Text = "0";
                    number3 = 0;
                    number2 = 0;
                    operation = operation1;
                }
                else
                {
                    compute(operation);
                    number3 = double.Parse(textEditor.Text);
                    operation = operation1;
                    string last_number2 = textEditor.Text.Split(op).Last();
                    number2 = (float)Convert.ToDouble(last_number2);
                }
            }
        }

    }
}
