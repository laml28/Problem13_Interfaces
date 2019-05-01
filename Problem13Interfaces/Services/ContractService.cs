using System;
using System.Collections.Generic;
using System.Text;
using Problem13Interfaces.Entities;

namespace Problem13Interfaces.Services
{
    class ContractService
    {
        private IPaymentService _paymentService;

        public ContractService(IPaymentService paymentService)
        {
            _paymentService = paymentService;
        }

        public void ProcessContract(Contract contract, int numberOfInstallments)
        {
            double baseValue = contract.TotalValue / numberOfInstallments;
            for (int i = 1; i <= numberOfInstallments; i++)
            {
                double installmentValue = baseValue + _paymentService.ServiceTax(i, baseValue);
                contract.AddInstallment(new Installment(contract.Date.AddMonths(i), installmentValue));
            }
        }

    }
}
