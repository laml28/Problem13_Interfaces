using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace Problem13Interfaces.Entities
{
    class Contract
    {
        public int Number { get; set; }
        public DateTime Date { get; set; }
        public double TotalValue { get; set; }
        public List<Installment> Installments { get; set; }

        public Contract(int number, DateTime date, double totalValue)
        {
            Number = number;
            Date = date;
            TotalValue = totalValue;
            Installments = new List<Installment>();
        }

        public void AddInstallment(Installment installment)
        {
            Installments.Add(installment);
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Contract #" + Number);
            sb.AppendLine("Total value: $" + TotalValue.ToString("F2", CultureInfo.InvariantCulture));
            sb.AppendLine("Installments");
            foreach (Installment installment in Installments)
            {
                sb.AppendLine(installment.DueDate.ToShortDateString() + " - " + "$" + installment.Value.ToString("F2", CultureInfo.InvariantCulture));
            }
            return sb.ToString();
        }

    }
}
