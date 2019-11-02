using System;

namespace AmortizationCalculator
{
    class LoanTermCalculator
    {
        public LoanTerm GetMonthsUntilPaid(LoanEntity loan)
        {
            return new LoanTerm(-Math.Log(1 - (loan.GetCurrentBalance() * loan.GetMonthlyInterestRate() / loan.GetMinimumMonthlyPayment()))
                / Math.Log(1 + loan.GetMonthlyInterestRate()));
        }
    }
}
