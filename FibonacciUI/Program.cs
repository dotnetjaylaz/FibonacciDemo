using FibonacciDemo;
using System;

namespace FibonacciUI
{
    internal class Program
    {
        /// <summary>
        /// This is a simple UI to interface with the CalculateFibonacci method in the calculationHelper class.
        /// This test code is submitted by Jay Lazzaro
        /// For support call 503.317.9727
        /// </summary>
        /// <param name="args">None</param>
        private static void Main(string[] args)
        {
            CalculationHelper calchelper = new CalculationHelper();
            Console.WriteLine("The 10th postion of the Fibonacci sequence is: " + calchelper.CalculateFibonacci(10));
            Console.WriteLine("The 40th postion of the Fibonacci sequence is: " + calchelper.CalculateFibonacci(40));
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Press any key to end");
            Console.ReadKey();
        }
    }
}