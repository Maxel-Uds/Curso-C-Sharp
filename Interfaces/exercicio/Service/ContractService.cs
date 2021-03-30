using System;
using exercicio.Entites;

namespace exercicio.Service
{
    public class ContractService
    {
        private IServicePayment _servicePayment;

        public ContractService(IServicePayment servicePayment)
        {
            _servicePayment = servicePayment;
        }
        public void ProcessContract(Contract contract, int months)
        {
            double basicQuota = contract.TotalValue/months;
            for(int i = 1; i <= months; i++)
            {
                DateTime dueDate = contract.Date.AddMonths(i);
                double total = _servicePayment.Total(basicQuota, i);
                contract.AddInstallment(new Installment(dueDate, total));
            }
        }
    }
}