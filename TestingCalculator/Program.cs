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
                    Console.WriteLine("Do you want to calculate with 2 (type 2) or 4 (type 4) numbers?");
                    int option = int.Parse(Console.ReadLine());


                    if (option == 2)
                    {
                        
                        Console.WriteLine("Enter your first number");
                       decimal num1 = AskUserForNumber();
                        Console.WriteLine("Enter your second number");
                        decimal num2 = AskUserForNumber();

                        Calc calculation = new Calc(num1, num2);

                        char chooseMethod = MenuSelection();

                        switch (chooseMethod)
                        {
                            case '-':
                                Console.WriteLine("The answer is " + calculation.Subtraction(num1, num2));
                                break;
                            case '+':
                                Console.WriteLine("The answer is " + calculation.Addition(num1, num2));
                                break;
                            case '/':
                                Console.WriteLine("The answer is " + calculation.Division());
                                break;
                            case '*':
                                Console.WriteLine("The answer is " + calculation.Multiplication());
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
                        
                    }
                    else if (option == 4)
                    {
                        Console.WriteLine("Enter five numbers");

                        decimal[] numberArray = new decimal[5];

                        for (int i = 0; i < numberArray.Length; i++)
                        {
                            numberArray[i] = AskUserForNumber();
                        }

                        Calc calculationArray = new Calc(numberArray);

                        char chooseMethod = MenuSelectionArray();

                        switch (chooseMethod)
                        {
                            case '-':
                                Console.WriteLine("The answer is " + calculationArray.Subtraction(numberArray));
                                break;
                            case '+':
                                Console.WriteLine("The answer is " + calculationArray.Addition(numberArray));
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
                    }

                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Choose option 2 or 4!");
                        Console.ResetColor();

                    }



                    Console.ResetColor();
                    Console.WriteLine("Hit any key to continue");
                    Console.ReadKey();
                    Console.Clear();

                }//try

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

        static char MenuSelectionArray()
        {
            Console.WriteLine("Enter a calculation method or press e to exit:");
            Console.WriteLine("- for Subtraction");
            Console.WriteLine("+ for Addition");

            char calculationChoice = char.Parse(Console.ReadLine());
            return calculationChoice;
        }

        
        static decimal AskUserForNumber()
        {
            decimal number;

            while (true)
            {

                try
                {
                    //Console.Write($"Enter your {order} number: ");
                    string askUserNumber = Console.ReadLine();

                    if (decimal.TryParse(askUserNumber, out number))
                    {
                        return number;
                    }

                    //This code needs to be there to display error???
                     else
                     {
                         Console.ForegroundColor = ConsoleColor.Red;
                         Console.WriteLine("You must type a number, please try again!");
                         Console.ResetColor();
                     }

                }
                catch (FormatException)
                {
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine("You must type a number, please try again!");
                    Console.ResetColor();
                }
            }//while













        }//AskUserForNumber
    }//class
}//namespace
