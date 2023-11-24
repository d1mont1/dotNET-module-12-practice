using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary;

namespace dotNET_module_12_practice
{
    class Program
    {
        static void ex1()
        {
            Console.WriteLine("\nЗАДАНИЕ №1\n");
            MyClass myObject = new MyClass();

            myObject.PropertyChanged += (sender, e) =>
            {
                Console.WriteLine($"Свойство {e.PropertyName} было изменено.");
            };

            myObject.MyProperty = "Новое значение";
        }
        
        static void additional_ex1()
        {
            Console.WriteLine("\nДОПОЛНИТЕЛЬНОЕ ЗАДАНИЕ №1\n");

            // Инициализация делегатов с использованием статических методов
            MathOperation add = new MathOperation(Calculator.Addition);
            MathOperation subtract = new MathOperation(Calculator.Subtraction);
            MathOperation multiply = new MathOperation(Calculator.Multiplication);
            MathOperation divide = new MathOperation(Calculator.Division);

            Calculator.PerformOperation(10, 5, add); 
            Calculator.PerformOperation(10, 5, subtract); 
            Calculator.PerformOperation(10, 5, multiply); 
            Calculator.PerformOperation(10, 5, divide); 

            MathOperation anonymousAdd = delegate (double a, double b)
            {
                return a + b;
            };

            Calculator.PerformOperation(20, 8, anonymousAdd); 

            // Использование лямбда-выражений
            MathOperation lambdaSubtract = (a, b) => a - b;

            Calculator.PerformOperation(20, 8, lambdaSubtract); 

            MathOperation chainedOperations = add + subtract + multiply;

            // Выполнение цепочки операций
            double result = chainedOperations(5, 3);
            Console.WriteLine($"Результат цепочки операций: {result}");

        }
        static void Main(string[] args)
        {
            ex1();
            additional_ex1();
        }
    }
}
