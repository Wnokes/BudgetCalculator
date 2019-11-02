using System;

namespace AmortizationCalculator
{
    public class AmortizationRow
    {
        private readonly int PaymentNumber;
        private readonly DateTime PaymentDate;
        private readonly double PaymentAmount;
        private readonly double InterestPayment;
        private readonly double PrincipalPayment;
        private readonly double Balance;

        public static AmortizationRow.Builder NewBuilder()
        {
            return new Builder();
        }

        private AmortizationRow(int paymentNumber,
            DateTime paymentDate,
            double paymentAmount,
            double interestPayment,
            double principalPayment,
            double balance)
        {
            PaymentNumber = paymentNumber;
            PaymentDate = paymentDate;
            PaymentAmount = paymentAmount;
            InterestPayment = interestPayment;
            PrincipalPayment = principalPayment;
            Balance = balance;
        }

        public int GetPaymentNumber()
        {
            return PaymentNumber;
        }

        public double GetPaymentAmount()
        {
            return PaymentAmount;
        }

        public DateTime GetPaymentDate()
        {
            return PaymentDate;
        }

        public double GetInterest()
        {
            return InterestPayment;
        }

        public double GetPrincipal()
        {
            return PrincipalPayment;
        }

        public double GetBalance()
        {
            return Balance;
        }

        public class Builder
        {
            private  int PaymentNumber;
            private  DateTime PaymentDate;
            private  double PaymentAmount;
            private  double InterestPayment;
            private  double PrincipalPayment;
            private  double Balance;

            public Builder WithPaymentNumber(int paymentNumber)
            {
                PaymentNumber = paymentNumber;
                return this;
            }

            public Builder WithPaymentDate(DateTime paymentDate)
            {
                PaymentDate = paymentDate;
                return this;
            }

            public Builder WithPaymentAmount(double paymentAmount)
            {
                PaymentAmount = paymentAmount;
                return this;
            }

            public Builder WithInterestPayment(double interestPayment)
            {
                InterestPayment = interestPayment;
                return this;
            }

            public Builder WithPrincipal(double principal)
            {
                PrincipalPayment = principal;
                return this;
            }

            public Builder WithBalance(double balance)
            {
                Balance = balance;
                return this;
            }

            public AmortizationRow Build()
            {
                return new AmortizationRow(PaymentNumber,
                                           PaymentDate,
                                           PaymentAmount,
                                           InterestPayment,
                                           PrincipalPayment,
                                           Balance);
            }
        }
    }
}
