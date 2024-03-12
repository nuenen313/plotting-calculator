using System;
using System.Linq;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace calculate
{
    public class Calculator
    {
        public static string operation;
        public static float number1;
        public static float number2;
        public static double number3;
        public static double result2;
        public static float result;
        public static string info;

        public Calculator()
        {
            
        }

        public static void DisableAllButtonsExcept(params Button[] buttonsToKeepEnabled)
        {
            foreach (Control control in Application.OpenForms[0].Controls)
            {
                if (control is Button button)
                {
                    if (!buttonsToKeepEnabled.Contains(button))
                    {
                        button.Enabled = false;
                    }
                }
            }
        }

        public static void EnableAllButtons()
        {
            foreach (Control control in Application.OpenForms[0].Controls)
            {
                if (control is Button button)
                {
                    button.Enabled = true;
                }
            }
        }

        public static bool CheckTextLength(TextBox textEditor, params Button[] buttonsToKeepEnabled)
        {
            if (textEditor.Text.Length > 30)
            {
                textEditor.Text = "Value is too large to compute";
                DisableAllButtonsExcept(buttonsToKeepEnabled);
                return true;
            }
            return false;
        }

        public static void Plot()
        {
            Form2 plottingForm = new Form2();
            plottingForm.Show();
        }

        public static (float, double, string) Compute(float number1, float number2, double number3, string operation)
        {
            info = "";
            switch (operation)
            {
                case "+":
                    result = number1 + number2;
                    break;
                case "-":
                    result = number1 - number2;
                    break;
                case "×":
                    result = number1 * number2;

                    break;
                case "÷":
                    if (number2 == 0)
                    {
                        info = "Invalid operation";
                        number3 = number1;
                        break;
                    }
                    else
                    {
                        result = number1 / number2;
                    }
                    break;
                case "sin":
                    result2 = Math.Sin(number3 * Math.PI / 180);
                    break;
                case "cos":
                    result2 = Math.Cos(number3 * Math.PI / 180);
                    break;
                case "tg":
                    if (number3 % 90 == 0)
                    {
                        info = "x value out of the function domain";
                    }
                    else
                    {
                        result2 = Math.Round(Math.Tan(number3 * Math.PI / 180), 10);
                        info = result2.ToString();
                    }
                    break;
                case "ctg":
                    if (number3 % 180 == 0 || number3 == 0)
                    {
                        info = "x value out of the function domain";
                    }
                    else
                    {
                        result2 = Math.Round(1 / Math.Tan(number3 * Math.PI / 180), 10);
                    }
                    break;
                case "none":
                    result = number1;
                    break;
                default:
                    break;
            }
            return (result, result2, info);
        }
    }
}
