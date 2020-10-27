using Exercicio14.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Exercicio14.Services
{
    class ContractService
    {
        private IPaymentService _paymentService;

        public ContractService(IPaymentService paymentService)
        {
            _paymentService = paymentService;
        }

        public void ProcessContract(Contract contract, int month)
        {
            double value = contract.TotalValue / month;
            for(int i = 1; i <= month; i++)
            {
                DateTime date = contract.Date.AddMonths(i);
                double updateValue = value + _paymentService.Interest(contract.TotalValue, i);
                _paymentService.Payment(contract.TotalValue);
            }
        }
    }
}
