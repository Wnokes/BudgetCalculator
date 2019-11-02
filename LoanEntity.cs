namespace AmortizationCalculator
{
    class LoanEntity
    {
        private double Principle;
        private double CurrentBalance;
        private double APR;
        private double MinimumMonthlyPayment;

        public LoanEntity(double principle, double currentBalance, double apr, double minimumMonthlyPayment)
        {
            Principle = principle;
            CurrentBalance = currentBalance;
            APR = apr;
            MinimumMonthlyPayment = minimumMonthlyPayment;
        }

        public double GetPrinciple()
        {
            return Principle;
        }

        public double GetCurrentBalance()
        {
            return CurrentBalance;
        }

        public double GetMinimumMonthlyPayment()
        {
            return MinimumMonthlyPayment;
        }

        public double GetMonthlyInterestRate()
        {
            return APR / 12;
        }
    }
}
