using DotNetCoreLearningTask.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetCoreLearningTask
{
    public class Multiply : ICalculate
    {
        public int Calculate(int a, int b)
        {
            int result = 0;
            for (int i = 0; i < b; i++)
            {
                result += a;
            }
            return b < 0 ? -result : result;
        }
    }
}
