using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    public static class Utilities
    {
        public static void CalculateMean(int[] numberInput, out double mean, out int countOfNumbers)
        {
            int sum = 0,
                 count = 0;

            foreach (int number in numberInput)
            {
                if (number > 0 && number <= 100)
                {
                    sum += number;
                    count++;
                }
            }

            mean = sum / count;
            countOfNumbers = count;
        }
    }
}
