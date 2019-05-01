using System;
using System.Collections.Generic;
using System.Text;
using Problem13Interfaces.Entities;

namespace Problem13Interfaces.Services
{
    class Paypal : IPaymentService
    {
        private readonly double InterestRate = 0.01;
        private readonly double SingleTax = 0.02;

        public double ServiceTax(int months, double value)
        {
            double simpleInterest = value * InterestRate * months;
            double paymentTax = (value + simpleInterest) * SingleTax;
            return simpleInterest + paymentTax;
        }
    }
}
