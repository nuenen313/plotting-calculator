using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculate
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //variables
        float number1;
        float number2;
        double number3;
        double result2;
        string operation;
        float result;

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (!(e.KeyCode >= Keys.D0 && e.KeyCode <= Keys.D9) && e.KeyCode != Keys.Oemcomma)
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

        private void button_comma_Click(object sender, EventArgs e)
        {

            string text = textEditor.Text;
            char lastCharacter = text[text.Length - 1];
            if (text.Length == 0)
            {
                textEditor.AppendText("0,");
            }
            else
            {
                if (lastCharacter == '+' || lastCharacter == '-' || lastCharacter == '×' || lastCharacter == '÷')
                {
                    textEditor.AppendText("0,");
                }
                else
                {
                    textEditor.AppendText(",");
                }
            }
        }

        private void button_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button_add_Click(object sender, EventArgs e)
        {
            //operation = "+";
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

        private void button_subtract_Click(object sender, EventArgs e)
        {
            //operation = "-";
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

        private void button_multiply_Click(object sender, EventArgs e)
        {
            //operation = "×";
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

        private void button_divide_Click(object sender, EventArgs e)
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

        private void button_equals_Click(object sender, EventArgs e)
        {
            textEditor.ReadOnly = false;
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
            button_comma.Enabled = true;
            button_add.Enabled = true;
            button_subtract.Enabled = true;
            button_multiply.Enabled = true;
            button_divide.Enabled = true;
            button_backspace.Enabled = true;
            button_sin.Enabled = true;
            button_cos.Enabled = true;
            string total = textEditor.Text;
            if (!(operation == "sin" || operation == "cos"))
            {
                char op = Convert.ToChar(operation);
                string num2 = total.Split(op).Last();
                number2 = float.Parse(num2);
            }

            textEditor.Clear();
            compute(operation);
        }

        private void button_clear_Click(object sender, EventArgs e)
        {
            textEditor.Clear();
            textEditor.ReadOnly = false;
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
            button_comma.Enabled = true;
            button_add.Enabled = true;
            button_subtract.Enabled = true;
            button_multiply.Enabled = true;
            button_divide.Enabled = true;
            button_backspace.Enabled = true;
            button_cos.Enabled = true;
            button_sin.Enabled = true;
        }

        private void button_backspace_Click(object sender, EventArgs e)
        {
            int textLength = textEditor.Text.Length;
            string text = textEditor.Text;
            text = text.Remove(textLength - 1);
            textEditor.Text = text;
        }

        private void button_sin_Click(object sender, EventArgs e)
        {
            if (textEditor.Text.Length > 0)
            {
                operation = "sin";
                string text = textEditor.Text;
                char lastElement = text[text.Length - 1];
                if (lastElement == '+' || lastElement == '-' || lastElement == '×' || lastElement == '÷')
                {
                    text = text.Remove(text.Length - 1);
                    textEditor.Text = text;
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
                button_comma.Enabled = false;
                button_add.Enabled = false;
                button_subtract.Enabled = false;
                button_multiply.Enabled = false;
                button_divide.Enabled = false;
                button_backspace.Enabled = false;
                button_cos.Enabled = false;
                button_sin.Enabled = false;
            }
        }

        private void button_cos_Click(object sender, EventArgs e)
        {
            if (textEditor.Text.Length > 0)
            {
                operation = "cos";
                string text = textEditor.Text;
                char lastElement = text[text.Length - 1];
                if (lastElement == '+' || lastElement == '-' || lastElement == '×' || lastElement == '÷')
                {
                    text = text.Remove(text.Length - 1);
                    textEditor.Text = text;
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
                button_comma.Enabled = false;
                button_add.Enabled = false;
                button_subtract.Enabled = false;
                button_multiply.Enabled = false;
                button_divide.Enabled = false;
                button_backspace.Enabled = false;
                button_sin.Enabled = false;
                button_cos.Enabled = false;
            }
        }

        public void compute(string operation)
        {
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
                    result = number1 / number2;
                    textEditor.Text = result.ToString();
                    break;
                case "sin":
                    result2 = Math.Sin(number3);
                    textEditor.Text = result2.ToString();
                    break;
                case "cos":
                    result2 = Math.Cos(number3);
                    textEditor.Text= result2.ToString();
                    break;
                default:
                    break;
            }
        }
    }
}
