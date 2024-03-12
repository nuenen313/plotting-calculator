using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
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
        private Calculator calculator;

        public Form1()
        {
            CultureInfo culture = CultureInfo.InvariantCulture;
            CultureInfo.DefaultThreadCurrentCulture = culture;
            CultureInfo.DefaultThreadCurrentUICulture = culture;

            InitializeComponent();
            calculator = new Calculator();
        }

        float number1;
        float number2;
        public static double number3;
        public static double result2;
        public static string operation;
        public static string info = "";
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
            if (Calculator.CheckTextLength(textEditor, button_clear, button_equals, button_quadratic))
            {

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
            if (Calculator.CheckTextLength(textEditor, button_clear, button_equals, button_quadratic))
            {

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
            if (Calculator.CheckTextLength(textEditor, button_clear, button_equals, button_quadratic))
            {

            }
            else
            {
                string text = textEditor.Text;
                if (text.Length == 0)
                {
                    textEditor.AppendText("0.");
                }
                else
                {
                    char lastCharacter = text[text.Length - 1];
                    int commaCount = 0;
                    foreach (char c in text)
                    {
                        if (c == '.')
                        {
                            commaCount++;
                        }
                    }
                    if (lastCharacter == '+' || lastCharacter == '-' || lastCharacter == '×' || lastCharacter == '÷')
                    {
                        textEditor.AppendText("0.");
                    }
                    else if (text.EndsWith("."))
                    {

                    }
                    else if (text.Contains("."))
                    {
                        if ((text.Contains("+") || text.Contains("-") || text.Contains("×") || text.Contains("÷")))
                        {
                            char op = Convert.ToChar(operation);
                            string last_number = text.Split(op).Last();

                            if (last_number.Contains('.'))
                            {
                                textEditor.AppendText("");
                            }
                            else
                            {
                                textEditor.AppendText(".");
                            }
                        }
                        else
                        {
                            textEditor.AppendText("");
                        }
                    }
                    else
                    {
                        textEditor.AppendText(".");
                    }
                }
            }
        }

        private void button_add_Click(object sender, EventArgs e)
        {
            check_E();
            if (Calculator.CheckTextLength(textEditor, button_clear, button_equals, button_quadratic))
            {

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
            if (Calculator.CheckTextLength(textEditor, button_clear, button_equals, button_quadratic))
            {

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
            if (Calculator.CheckTextLength(textEditor, button_clear, button_equals, button_quadratic))
            {

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
            if (Calculator.CheckTextLength(textEditor, button_clear, button_equals, button_quadratic))
            {

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
            if (Calculator.CheckTextLength(textEditor, button_clear, button_equals, button_quadratic))
            {

            }
            else
            {
                if (textEditor.Text.Length > 0)
                {
                    operation = "sin";
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
                    Calculator.DisableAllButtonsExcept(button_clear, button_equals, button_quadratic);
                }
            }
        }

        private void button_cos_Click(object sender, EventArgs e) 
        {
            check_E();
            if (Calculator.CheckTextLength(textEditor, button_clear, button_equals, button_quadratic))
            {

            }
            else
            {
                if (textEditor.Text.Length > 0)
                {
                    operation = "cos";
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
                    Calculator.DisableAllButtonsExcept(button_clear, button_equals, button_quadratic);
                }
            }
        }

        private void button_tg_Click(object sender, EventArgs e)
        {
            check_E();
            if (Calculator.CheckTextLength(textEditor, button_clear, button_equals, button_quadratic))
            {

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
                    textEditor.Text = "tan(" + Convert.ToString(number3) + ")";
                    textEditor.ReadOnly = true;
                    Calculator.DisableAllButtonsExcept(button_clear, button_equals, button_quadratic);
                }
            }
        }

        private void button_ctg_Click(object sender, EventArgs e)
        {
            check_E();
            if (Calculator.CheckTextLength(textEditor, button_clear, button_equals, button_quadratic))
            {

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
                    textEditor.Text = "cot(" + Convert.ToString(number3) + ")";
                    textEditor.ReadOnly = true;
                    Calculator.DisableAllButtonsExcept(button_clear, button_equals, button_quadratic);
                }
            }
        }

        private void button_equals_Click(object sender, EventArgs e)
        {
            check_E();
            if (Calculator.CheckTextLength(textEditor, button_clear, button_equals, button_quadratic))
            {

            }
            else
            {
                textEditor.ReadOnly = false;
                Calculator.EnableAllButtons();
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
                check_E();
                (result, result2, info) = Calculator.Compute(number1, number2, number3, operation);

                if (info != null && info.Length > 1)
                {
                    textEditor.Text = info;
                    Calculator.DisableAllButtonsExcept(button_clear, button_quadratic);
                    info = "";
                }
                else
                {
                    if (operation == "sin" || operation == "cos" || operation == "none" || operation == "rad" || operation == "tg" || operation == "ctg")
                    {
                        textEditor.Text = result2.ToString();
                        Calculator.Plot();
                    }
                    else
                    {
                        textEditor.Text = result.ToString();
                    }
                }

                number1 = 0;
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            check_E();
            if (Calculator.CheckTextLength(textEditor, button_clear, button_equals, button_quadratic))
            {

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
            info = "";
            Calculator.EnableAllButtons();
        }

        private void button_backspace_Click(object sender, EventArgs e)
        {
            check_E();
            if (Calculator.CheckTextLength(textEditor, button_clear, button_equals, button_quadratic))
            {

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

        public void plot()
        {
            Form2 plottingForm = new Form2();
            plottingForm.Show();
        }

        private void check_E()
        {
            if (textEditor.Text.Contains('E'))
            {
                Calculator.DisableAllButtonsExcept(button_clear, button_equals, button_quadratic);
            }
        }

        private void trigonometric_function(string operation1, char lastElement, string text)
        {
            info = "";
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
                (result, result2, info) = Calculator.Compute(number1, number2, number3, operation);
                if (info != null)
                {
                    textEditor.Text = info;
                    Calculator.DisableAllButtonsExcept(button_clear, button_quadratic);
                }
                else
                {
                    textEditor.Text = result.ToString();
                }
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
                (result, result2, info) = Calculator.Compute(number1, number2, number3, operation);
                if (info != null && info.Length > 1)
                {
                    textEditor.Text = info;
                    Calculator.DisableAllButtonsExcept(button_clear, button_quadratic);
                    info = "";
                }
                else
                {
                    textEditor.Text = result.ToString();
                }
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
                (result, result2, info) = Calculator.Compute(number1, number2, number3, operation);
                if (info != null && info.Length > 1)
                {
                    textEditor.Text = info;
                    Calculator.DisableAllButtonsExcept(button_clear, button_quadratic);
                    info = "";
                }
                else
                {
                    textEditor.Text = result.ToString();
                }
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
                    (result, result2, info) = Calculator.Compute(number1, number2, number3, operation);
                    if (info != null && info.Length > 1)
                    {
                        textEditor.Text = info;
                        Calculator.DisableAllButtonsExcept(button_clear, button_quadratic);
                        info = "";
                    }
                    else
                    {
                        textEditor.Text = result.ToString();
                    }
                    number3 = double.Parse(textEditor.Text);
                    operation = operation1;
                    string last_number2 = textEditor.Text.Split(op).Last();
                    number2 = (float)Convert.ToDouble(last_number2);
                }
            }
        }


    }
}
