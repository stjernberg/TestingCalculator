using System;
using Xunit;
using TestingCalculator;


namespace TestingCalculator.Tests
{
    public class CalcTests
    {

        [Theory]
        [InlineData(4.23, -3, 1.23)]
        [InlineData(5, -8.45, -3.45)]
        [InlineData(-1, 3, 2)]
        public void AdditionTest(decimal num1, decimal num2, decimal expected)
        {
            Calc testAddition = new Calc();
            decimal result = testAddition.Addition(num1, num2);
            Assert.Equal(expected, result);
        }

       
        [Theory]
        [InlineData( 8, 2.5, 1, -5, -1.75, 4.75 )]
        [InlineData(10, -8, 2, 1.5, -5.25, 0.25 )]
        [InlineData(6.45, -7.5, 4, -1.5, 5, 6.45 )]

        public void AdditionArrayTest( decimal num1, decimal num2, decimal num3, decimal num4, decimal num5, decimal expected )
        {                       
            Calc testAdditionArray = new Calc();
            decimal[] numberArray = { num1, num2, num3, num4, num5 };
            decimal result= testAdditionArray.Addition(numberArray);
            Assert.Equal(expected, result);           
        }

        [Theory]
        [InlineData(-4, -8.6, 4.6 )]
        [InlineData(14, 2.30, 11.7)]
        [InlineData(-0.25, -4.70, 4.45)]
        public void SubtractionTest(decimal num1, decimal num2, decimal expected)
        {

            Calc testSubtraction = new Calc();
            decimal result = testSubtraction.Subtraction(num1, num2);
            Assert.Equal(expected, result);

        }
        [Theory]
        [InlineData(5, -4, -20)]
        [InlineData(2.25, 5.62, 12.645)]
        [InlineData(-0.6, -6.7, 4.02)]
        public void MultiplicationTest(decimal num1, decimal num2, decimal expected)
        {
            Calc testMultiplication = new Calc();
            decimal result = testMultiplication.Multiplication(num1, num2);
            Assert.Equal(expected, result);
        } 
        
        [Theory]
        [InlineData(5, -4, -20)]
        [InlineData(2.25, 5.62, 12.645)]
        [InlineData(-0.6, -6.7, 4.02)]
        public void DivisionTest(decimal num1, decimal num2, decimal expected)
        {
            Calc testDivision = new Calc();
            decimal result = testDivision.Division(num1, num2);
            Assert.Equal(expected, result);
        }


    }//class
}//namespace
