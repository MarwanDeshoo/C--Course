using System;

namespace MathOperationApp
{
    // Define a class called MyMathClass
    class MyMathClass
    {
        // Define a void method that takes two integers as parameters
        public void DoMathOperation(int number1, int number2)
        {
            // Perform a math operation on the first integer (e.g., multiply by 2)
            int result = number1 * 2;

            // Display the result of the operation on the first integer
            Console.WriteLine("Result of math operation on number1: " + result);

            // Display the second integer to the console
            Console.WriteLine("The second number (number2) is: " + number2);
        }
    }

    class Program
    {
        // Main method — entry point of the console application
        static void Main(string[] args)
        {
            // Instantiate the class
            MyMathClass mathObj = new MyMathClass();

            // Call the method, passing in two numbers using positional arguments
            mathObj.DoMathOperation(5, 10);

            // Call the method again, this time using named arguments
            mathObj.DoMathOperation(number2: 20, number1: 7);

            // Pause the console so it doesn't close immediately
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}
