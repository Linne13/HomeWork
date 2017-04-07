using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WindowsFormsApplication1
{
    public class Calculator
    {
        public double firstNumber;
        public double secondNumber;
        public double result;
        public char symbol;

        public double Plus()
        {
            result = firstNumber + secondNumber;
            return result;
        }

        public double Minus()
        {
            result = firstNumber - secondNumber;
            return result;
        }

        public double Mult()
        {
            result = firstNumber * secondNumber;
            return result;
        }

        public double Divide()
        {
            result = firstNumber / secondNumber;
            return result;
        }

        public double Square()
        {
            result = Math.Pow(firstNumber, secondNumber);
            return result;
        }

    }
}
