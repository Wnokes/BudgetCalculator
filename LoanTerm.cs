using System;

namespace AmortizationCalculator
{
    class LoanTerm
    {
        readonly double LengthOfLoan;
        public LoanTerm(double lengthOfLoan)
        {
            LengthOfLoan = lengthOfLoan;
        }

        public int getMonthsUntilPaidOff()
        {
            return (int)Math.Ceiling(LengthOfLoan);
        }
    }
}
