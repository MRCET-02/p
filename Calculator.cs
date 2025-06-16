using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConAppCalc
{
    public class Calculator
    {
        public int Add(int num1, int num2)
        {
            int result = num1 + num2;
            return result;
        }
        public int Subtract(int num1, int num2)
        {
            int result = num1 - num2;
            return result;
        }
        public int Multiply(int num1, int num2)
        {
            int result = num1 * num2;
            return result;
        }
        public int Divide(int num1, int num2)
        {
            if (num2 == 0)
            {
                throw new DivideByZeroException("Cannot divide by zero.");
            }
            int result = num1 / num2;
            return result;
        }
    }
}
