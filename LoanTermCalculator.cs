using System;

namespace AmortizationCalculator
{
    class Calculator
    {
        int _balance;
        float _interestRate;
        float _monthlyInterestRate;
        int _monthlyPayment;
        public Calculator(int balance, float interestRate, int monthlyPayment)
        {
            _balance = balance;
            _interestRate = interestRate;
            _monthlyInterestRate = interestRate / 12;
            _monthlyPayment = monthlyPayment;
        }

        public float GetMonthlyInterestRate()
        {
            return _monthlyInterestRate;
        }

        public double GetMonthsUntilPaid()
        {
            return GetFisrtPart() / GetSecondPart();
        }

        public double GetFisrtPart()
        {
            return -Math.Log(GetInside());
        }

        public double GetInside()
        {
            return 1 - ((_balance * _monthlyInterestRate) / _monthlyPayment);
        }

        public double GetSecondPart()
        {
            return Math.Log(1 + _monthlyInterestRate);
        }
    }
}
