using System;

namespace TestingCalculator
{
    public class Calc
    {
        
       public Calc()
        {
 
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
            decimal dif = numberArray[0];

            for (int i = 1; i < numberArray.Length; i++)
            {
                dif -= numberArray[i];
            }
            return dif;
        }
        public decimal Multiplication(decimal nr1, decimal nr2)
        {
            decimal prod = nr1 * nr2;
            return prod;
        }

        public decimal Division(decimal nr1, decimal nr2)
        {
            decimal quote = nr1 / nr2;
            return quote;
        }


    }//Calc
}//namespace
