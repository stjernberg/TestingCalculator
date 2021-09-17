using System;
//using System.Collections.Generic;
//using System.Text;

namespace TestingCalculator
{
    class Calc
    {
        private decimal nr1;
        public decimal nr2;
        public decimal[] numberArray;



        public Calc(decimal nr1, decimal nr2)
        {
            this.nr1 = nr1;
            this.nr2 = nr2;
        }

        public Calc(decimal[] numberArray)
        {
            this.numberArray = numberArray;

        }


        public decimal Addition(decimal nr1, decimal nr2)
        {
            decimal sum = nr1 + nr2;
            return sum;
        }

        public decimal Addition(decimal[] numberArray)
        {
            decimal sum = 0;

            for (int i = 0; i < numberArray.Length; i++)
            {
                sum += numberArray[i];
            }
            return sum;
        }
        public decimal Subtraction(decimal nr1, decimal nr2)
        {
            decimal dif = nr1 - nr2;
            return dif;
        }

        public decimal Subtraction(decimal[] numberArray)
        {

            decimal dif = 0;

            for (int i = 0; i < numberArray.Length; i++)
            {
                dif -= numberArray[i];
            }
            return dif;
        }
        public decimal Multiplication()
        {
            decimal prod = nr1 * nr2;
            return prod;
        }

        public decimal Division()
        {

            decimal quote = nr1 / nr2;

           
                try
                {
                    
                    if (nr2 != 0)
                    {
                        return quote;
                    }

                }

                catch (DivideByZeroException e)
                { 
                    Console.WriteLine(e.Message);
                
                }          

        }


    }//Calc
}//namespace
