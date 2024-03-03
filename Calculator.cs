using System;
using System.Linq;

namespace calculate
{
    public class Calculator
    {
        private float number1;
        private float number2;
        private double number3;
        private double result;
        private string operation;

        public Calculator()
        {
            
        }

        public double CalculateResult(string expression)
        {
            ParseExpression(expression);
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
                    if (Math.Abs(number2) < float.Epsilon)
                    {
                        throw new DivideByZeroException("Division by zero");
                    }
                    result = number1 / number2;
                    break;
                default:
                    throw new ArgumentException("Invalid operation");
            }
            return result;
        }

        private void ParseExpression(string expression)
        {
            expression = expression.Replace(" ", "");

            int operatorIndex = -1;
            if (expression.Contains('+'))
                operatorIndex = expression.IndexOf('+');
            else if (expression.Contains('-'))
                operatorIndex = expression.IndexOf('-');
            else if (expression.Contains('×'))
                operatorIndex = expression.IndexOf('×');
            else if (expression.Contains('÷'))
                operatorIndex = expression.IndexOf('÷');

            if (operatorIndex == -1)
                throw new ArgumentException("Invalid expression.");

            string num1Str = expression.Substring(0, operatorIndex);
            if (!float.TryParse(num1Str, out number1))
                throw new ArgumentException("Invalid number format.");

            operation = expression[operatorIndex].ToString();

            string num2Str = expression.Substring(operatorIndex + 1);
            if (!float.TryParse(num2Str, out number2))
                throw new ArgumentException("Invalid number format.");
        }

    }
}
