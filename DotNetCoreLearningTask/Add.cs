using DotNetCoreLearningTask.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetCoreLearningTask
{
    public class Add : ICalculate
    {
        public int Calculate(int a, int b)
        {
            return a + b;
        }
    }
}
