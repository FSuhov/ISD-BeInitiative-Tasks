using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompoundInterestCalculator
{
    public static class Calculator
    {
        public static double GetEndValue(double startValue, double interest, int periods)
        {
            double endValue = startValue;
            for (int i = 0; i < periods; i++)
            {
                endValue += endValue * (interest/100);
            }

            return Math.Round(endValue,2);
        }

        public static double GetCompoundInterest(double startValue, double endValue, int periods)
        {
            double interest = Math.Pow((endValue / startValue), (1 / (double)periods)) - 1;

            return Math.Round(interest*100, 2);
        }
    }
}
