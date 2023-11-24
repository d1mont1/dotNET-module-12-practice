using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public delegate double MathOperation(double a, double b);

    public class Calculator
    {
        public static double Addition(double a, double b)
        {
            return a + b;
        }

        public static double Subtraction(double a, double b)
        {
            return a - b;
        }

        public static double Multiplication(double a, double b)
        {
            return a * b;
        }

        public static double Division(double a, double b)
        {
            if (b != 0)
                return a / b;
            else
                throw new ArgumentException("Деление на ноль невозможно");
        }

        public static void PerformOperation(double a, double b, MathOperation mathOperation)
        {
            double result = mathOperation(a, b);
            Console.WriteLine($"Результат операции: {result}");
        }
    }
}
