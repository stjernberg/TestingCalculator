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
                    Console.WriteLine("Do you want to calculate with 2 (type 2) or 5 (type 5) numbers press 0 to exit.");
                    int option = int.Parse(Console.ReadLine());

                    switch (option)
                    {
                        case 2:
                            CalculateTwoNumbers();
                            break;
                        case 5:
                            CalculateFiveNumbers();
                            break;
                        case 0:
                            keepCalculating = false;
                            Console.WriteLine("Good bye!");
                            break;
                        default:
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Choose option 2, 5 or e!");
                            break;
                    }

                    Console.ResetColor();
                    Console.WriteLine("Hit any key to continue");
                    Console.ReadKey();
                    Console.Clear();

                }

                catch (FormatException)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("That is not a valid option");
                    Console.ResetColor();
                }
            }


        }//main

        static void CalculateTwoNumbers()
        {

            bool isZero = true;
            while (isZero)
            {

                Console.WriteLine("Enter your first number");
                decimal num1 = AskUserForNumber();
                Console.WriteLine("Enter your second number");
                decimal num2 = AskUserForNumber();
                Calc calculation = new Calc();

                bool correctChoice = false;
                while (!correctChoice)
                {
                    try
                    {
                        char chooseMethod = MenuSelection();

                        switch (chooseMethod)
                        {
                            case '-':
                                Console.WriteLine("The answer is " + calculation.Subtraction(num1, num2));
                                isZero = false;
                                correctChoice = true;
                                break;
                            case '+':
                                Console.WriteLine("The answer is " + calculation.Addition(num1, num2));
                                correctChoice = true;
                                break;
                            case '/':

                                if (num2 != 0)
                                {
                                    Console.WriteLine("The answer is " + calculation.Division(num1, num2));
                                    isZero = false;
                                    correctChoice = true;
                                }

                                else
                                {
                                    correctChoice = true;
                                    throw new DivideByZeroException("You can't divide by zero!");                                   
                                }
                                break;
                            case '*':
                                Console.WriteLine("The answer is " + calculation.Multiplication(num1, num2));
                                isZero = false;
                                correctChoice = true;
                                break;

                            default:
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine("That is not a valid option");
                                Console.ResetColor();
                                break;
                        }
                    }

                    catch (Exception e)
                    {
                        Console.WriteLine(e.Message);
                    }
                }
            }
        }//CalculateTwoNumbers

        static void CalculateFiveNumbers()
        {
            Console.WriteLine("Enter five numbers");

            decimal[] numberArray = new decimal[5];

            for (int i = 0; i < numberArray.Length; i++)
            {
                numberArray[i] = AskUserForNumber();
            }

            Calc calculationArray = new Calc();

            bool correctChoice = false;
            while (!correctChoice)
            {
                try
                {
                    char chooseMethod = MenuSelectionArray();

                    switch (chooseMethod)
                    {
                        case '-':
                            Console.WriteLine("The answer is " + calculationArray.Subtraction(numberArray));
                            correctChoice = true;
                            break;
                        case '+':
                            Console.WriteLine("The answer is " + calculationArray.Addition(numberArray));
                            correctChoice = true;
                            break;
                        default:
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("That is not a valid option");
                            Console.ResetColor();
                            break;
                    }

                }

                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }
        }//CalculateFiveNumbers()
        static char MenuSelection()
        {
            Console.WriteLine("Enter a calculation method or press e to exit:");
            Console.WriteLine("- for Subtraction");
            Console.WriteLine("+ for Addition");
            Console.WriteLine("* for Multiplication");
            Console.WriteLine("/ for Division");

            char calculationChoice = char.Parse(Console.ReadLine());
            return calculationChoice;
        }//MenuSelection

        static char MenuSelectionArray()
        {
            Console.WriteLine("Enter a calculation method or press e to exit:");
            Console.WriteLine("- for Subtraction");
            Console.WriteLine("+ for Addition");

            char calculationChoice = char.Parse(Console.ReadLine());
            return calculationChoice;
        }//MenuSelectionArray


        static decimal AskUserForNumber()
        {
            decimal number;

            while (true)
            {
                try
                {
                    number = decimal.Parse(Console.ReadLine());
                    return number;

                }
                catch (FormatException)
                {
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine("You must type a number, please try again!");
                    Console.ResetColor();
                }
            }


        }//AskUserForNumber
    }//class
}//namespace
