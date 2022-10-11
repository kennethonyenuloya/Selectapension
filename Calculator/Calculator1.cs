using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    public class Calculator1
    {
        private double sumOfsquaredValueofDistanceToMean { get; set;  }
      
        //Mean
        public double MeanofNumberInput(int[] numbers) {

            int sum = 0,
                 count = 0;
            double mean = 0;

            if (numbers == null)
                throw new ArgumentNullException();

            foreach (int number in numbers)
            {
                if (number > 0 && number <= 100)
                {
                    sum += number;
                    count++;
                }
            }

            mean= sum / count;
            
            return mean;
        }
        
        //SD
        public double StandardDeviation(int[] numbers)
        {
            double standardDeviaton = 0;

            if (numbers == null)
                throw new ArgumentNullException();

            //Step 1: Calculate mean of valid inputs within range
            int countOfNumbers;
            double mean;
            Utilities.CalculateMean(numbers, out mean, out countOfNumbers);

            if (mean == 0)
                return standardDeviaton;

            //Step 2: square the distance of each array item from mean and get the sum

            foreach (int number in numbers)
            {
                if (number > 0 && number <= 100)
                {                    
                    var squaredValueofDistanceToMean = (number - mean) * (number - mean) ;
                    sumOfsquaredValueofDistanceToMean += squaredValueofDistanceToMean;
                }
            }

            //Step 3: divide the sum by the number of items within our range
            var sum = sumOfsquaredValueofDistanceToMean / countOfNumbers;

            //Step 4: get the square root
            standardDeviaton = Math.Sqrt(sum);

            return Convert.ToDouble(string.Format("{0:F2}", standardDeviaton));
        }

        //Histogram
        public double NumberOfFrequencyOfBins(int[] numbers)
        {
            return 0;
        }

        //Square root
        public double SquareRoot(int? number)
        {
            if (number == null)
                throw new ArgumentNullException("Invalid Argument");

            if (number < 0)
                throw new ArgumentOutOfRangeException("Argument Out of Range");

            var squareRoot=Math.Sqrt((double) number);
            return squareRoot;
        }
    }
}
