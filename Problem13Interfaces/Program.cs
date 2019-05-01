using System;
using System.Globalization;
using Problem13Interfaces.Entities;
using Problem13Interfaces.Services;

namespace Problem13Interfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter contract data");
            Console.Write("Number: ");
            int number = int.Parse(Console.ReadLine());
            Console.Write("Date (dd/MM/yyyy): ");
            DateTime date = DateTime.Parse(Console.ReadLine());
            Console.Write("Total value: ");
            double value = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Enter number of installments: ");
            int numInst = int.Parse(Console.ReadLine());
            Console.WriteLine();

            Contract contract = new Contract(number, date, value);

            ContractService contractService = new ContractService(new Paypal());
            contractService.ProcessContract(contract, numInst);

            Console.WriteLine(contract.ToString());

        }
    }
}
