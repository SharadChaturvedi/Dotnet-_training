using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace Test_3
{
    delegate int CalculatorOperation(int a, int b);
    //defining delegates for calculator operations

    class Delegates
    {
        static void Main()
        {
            //defining deleates  instances for add, sub , and multiply.
            CalculatorOperation Add = (a, b) => a + b;
            CalculatorOperation Subtract = (a, b) => a - b;
            CalculatorOperation Multiply = (a, b) => a * b;

            int num1, num2;

            // Prompting the user to enter two integers
            Console.WriteLine("Enter the first number:");
            num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the second number:");
            num2 = Convert.ToInt32(Console.ReadLine());

            // Displaying the results using a display function
            DisplayResult("Addition:---->", Add(num1, num2));
            DisplayResult("Subtraction:--->", Subtract(num1, num2));
            DisplayResult("Multiplication:---->", Multiply(num1, num2));
        }

        // Function to display the result
        static void DisplayResult(string operation, int result)
        {
            Console.WriteLine($"{operation}: {result}");
            Console.ReadLine();
        }
    }
}