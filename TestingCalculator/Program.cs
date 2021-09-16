using System;

namespace TestingCalculator
{
    class Program
    {
        static void Main(string[] args)
        {

            bool keepCalculating = true;

            while (keepCalculating)
            {
                try
                {
                    Console.WriteLine("Type your first number: ");
                    double num1 = double.Parse(Console.ReadLine());
                    Console.WriteLine("Type your second number: ");
                    double num2 = double.Parse(Console.ReadLine());

                    Calc addition = new Calc(num1, num2);
                    Calc subtraction = new Calc(num1, num2);
                    Calc multiplication = new Calc(num1, num2);
                    Calc division = new Calc(num1, num2);

                    char chooseMethod = MenuSelection();

                    switch (chooseMethod)
                    {
                        case '-':
                            Console.WriteLine("The answer is " + subtraction.Subtraction());
                            break;
                        case '+':
                            Console.WriteLine("The answer is " + addition.Addition());
                            break;
                        case '/':
                            Console.WriteLine("The answer is " + division.Division());
                            break;
                        case '*':
                            Console.WriteLine("The answer is " + multiplication.Multiplication());
                            break;
                        case 'e':
                            keepCalculating = false;
                            Console.WriteLine("Good bye!");
                            break;
                        default:
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("That is not a valid option");
                            break;

                    }
                    Console.ResetColor();
                    Console.WriteLine("Hit any key to continue");
                    Console.ReadKey();
                    Console.Clear();
                }
                catch
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("That is not a valid option");
                    Console.ResetColor();
                }

            }//while
           
        }//main

        static char MenuSelection()
        {
            Console.WriteLine("Enter a calculation method or press e to exit:");
            Console.WriteLine("- for Subtraction");
            Console.WriteLine("+ for Addition");
            Console.WriteLine("* for Multiplication");
            Console.WriteLine("/ for Division");

            char calculationChoice = char.Parse(Console.ReadLine());
            return calculationChoice;
        }
    }//class
}//namespace
