using System;
using System.Collections.Generic;
using System.Text;

namespace TestingCalculator
{
    class Calc
    {
        double nr1;
        double nr2;
        double[] numberArr = new double[5];

        public Calc(double nr1, double nr2)
        {
            this.nr1 = nr1;
            this.nr2 = nr2;
        }

        public Calc(double[] numberArr)
        {
            this.numberArr = numberArr;
        }

        public void Addition()
        {
            double sum = nr1 + nr2;
            Console.WriteLine(sum);
        }

        /*public static double[] Addition (double[] numberArr)
        {
            int sum;
        AskUserForNr();

            for (int i = 0; i <additionArr.Length; i++)
            {
               sum += additionArr[i];
            }
           return sum;
        }//Addition 
public static double AskUserForNr(double[] additionArr)
{
    return double[] }
 }*/

    }//Calc
}//namespace
