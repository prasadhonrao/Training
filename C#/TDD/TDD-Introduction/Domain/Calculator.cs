using System;

namespace Domain
{
    public class Calculator : ICalculator
    {
        public int Add(int firstNumber, int secondNumber)
        {
            if ((firstNumber == int.MaxValue && secondNumber > 0) ||
                (firstNumber > int.MaxValue && secondNumber > 0))
                throw new ArgumentOutOfRangeException("Arguments are out of range");

            return firstNumber + secondNumber;
        }
        public int Divide(int firstNumber, int secondNumber)
        {
            if (secondNumber == 0)
                throw new DivideByZeroException("Division by zero!");

            return firstNumber / secondNumber;
        }

    }
}
