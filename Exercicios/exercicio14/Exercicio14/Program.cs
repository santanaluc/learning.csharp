using System;
using System.Diagnostics.Contracts;
using System.Globalization;
using Exercicio14.Entities;
using Exercicio14.Services;
using Contract = Exercicio14.Entities.Contract;

namespace Exercicio14
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter contract data");
            int number = int.Parse(Console.ReadLine());
            Console.Write("Date (dd/MM/yyyy): ");
            DateTime date = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", CultureInfo.InvariantCulture);
            Console.Write("Contract value: ");
            double value = double.Parse(Console.ReadLine());

            Console.Write("Enter number of installments: ");
            int months = int.Parse(Console.ReadLine());

            Contract contract = new Contract(number, date, value);
            ContractService contractService = new ContractService(new PaypalService());
            contractService.ProcessContract(contract, months);

            Console.WriteLine("Installments:");
            foreach(Installment installment in contract.Installments)
            {
                Console.WriteLine(installment);
            }
        }
    }
}
