using System;

namespace TestingCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            

            Console.WriteLine("Type your first number: ");
            double num1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Type your second number: ");
            double num2 = double.Parse(Console.ReadLine());

            Calc addition = new Calc(num1, num2);
            addition.Addition();
        }
    }
}
