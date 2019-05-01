using System;
using System.Collections.Generic;
using System.Text;

namespace Problem13Interfaces.Entities
{
    class Installment
    {
        public DateTime DueDate { get; set; }
        public double Value { get; set; }

        public Installment(DateTime dueDate, double value)
        {
            DueDate = dueDate;
            Value = value;
        }
    }
}
