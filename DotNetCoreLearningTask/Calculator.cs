using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetCoreLearningTask
{
    public class Calculator
    {
        public int Add(int a, int b)
        {
            return a + b;
        }

        public int Subtract(int a, int b)
        {
            return a - b;
        }

        public int Multiply(int a, int b)
        {
            int result = 0;
            for (int i = 0; i < b; i++)
            {
                result += a;
            }
            return b < 0 ? -result : result;
        }

        public double Divide(int a, int b)
        {
            if (a == 0)
                return 0;
            if (b == 0)
                throw new DivideByZeroException("Division by zero is not allowed.");

            bool negResult = false;

            // Handling negative numbers 
            if (a < 0)
            {
                a = -a;
                if (b < 0)
                    b = -b;
                else
                    negResult = true;
            }
            else if (b < 0)
            {
                b = -b;
                negResult = true;
            }

            // if a is greater than equal to b , subtract b from a and increase quotient by one. 
            int quotient = 0;
            while (a >= b)
            {
                a = a - b;
                quotient++;
            }

            // checking if neg equals to 1 then making  quotient negative  
            if (negResult)
                quotient = -quotient;
            return quotient;
        }
    }
}
