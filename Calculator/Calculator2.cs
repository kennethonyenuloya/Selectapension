using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    public class Calculator2
    {
        private const int Percent= 100;
        public double CompoundIncrease(int? amount, int? rate, int? time)
        {
            if (amount == null || rate == null || time == null)
                throw new ArgumentNullException();

            if (amount <= 0 || rate <= 0 || time <= 0)
                throw new ArgumentOutOfRangeException();

            //Use the multiplier method
            double multiplier = (double)(Percent + rate) / 100;
            double multiplierByYears=1;

            //multiply multipler across the number of years. We do this this way because we don't want to use the inbuilt Exp function
            int i = 0;
            do
            {
                multiplierByYears *= multiplier;
                i++;
            }
            while (i < time);

            var compoundIncrease = amount * multiplierByYears;

            return Convert.ToDouble(string.Format("{0:F2}", compoundIncrease));
        }
    

        public double CompoundDecrease(int? amount, int? rate, int? time)
    {
        if (amount == null || rate == null || time == null)
            throw new ArgumentNullException();

        if (amount <=0 || rate <= 0 || time <= 0)
            throw new ArgumentOutOfRangeException();

        //Use the multiplier method
        double multiplier = (double)(Percent - rate) / 100;
        double multiplierByYears = 1;

        //multiply multipler across the number of years. We do this this way because we don't want to use the inbuilt Exp function
        int i = 0;
        do
        {
                multiplierByYears *= multiplier;
            i++;
        }
        while (i < time);

        var compoundDecrease = amount * multiplierByYears;

        return Convert.ToDouble(string.Format("{0:F2}", compoundDecrease));
    }
    }
}
