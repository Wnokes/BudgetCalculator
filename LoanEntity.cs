namespace AmortizationCalculator
{
    public class LoanEntity
    {
        private readonly string LoanName;
        private readonly double Principle;
        private readonly double CurrentBalance;
        private readonly double APR;
        private readonly double MinimumMonthlyPayment;

        public static Builder NewBuilder()
        {
            return new Builder();
        }

        private LoanEntity(string loanName, double principle, double currentBalance, double apr, double minimumMonthlyPayment)
        {
            LoanName = loanName;
            Principle = principle;
            CurrentBalance = currentBalance;
            APR = apr;
            MinimumMonthlyPayment = minimumMonthlyPayment;
        }

        public string GetLoanName()
        {
            return LoanName;
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

        public class Builder
        {
            private string LoanName;
            private double Principle;
            private double CurrentBalance;
            private double APR;
            private double MinimumMonthlyPayment;

            public Builder SetLoanName(string name)
            {
                LoanName = name;
                return this;
            }

            public Builder SetPrinciple(double amount)
            {
                Principle = amount;
                return this;
            }

            public Builder SetCurrentBalance(double amount)
            {
                CurrentBalance = amount;
                return this;
            }

            public Builder SetApr(double rate)
            {
                APR = rate;
                return this;
            }

            public Builder SetMinuminMonthlyPayment(double amount)
            {
                MinimumMonthlyPayment = amount;
                return this;
            }

            public LoanEntity Build()
            {
                return new LoanEntity(LoanName,
                                      Principle,
                                      CurrentBalance,
                                      APR,
                                      MinimumMonthlyPayment);
            }
        }
    }
}
