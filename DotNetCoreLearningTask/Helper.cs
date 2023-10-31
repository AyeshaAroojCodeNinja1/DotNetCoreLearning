using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetCoreLearningTask
{
    public static class Helper
    {
        public static bool ValidateValidInput(out int result, string prompt)
        {
            Console.Write(prompt);
            if (int.TryParse(Console.ReadLine(), out result))
            {
                return true;
            }
            Console.WriteLine("Invalid input. Please enter a valid number.");
            return false;
        }
    }
}
