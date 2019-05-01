using System;
using System.Collections.Generic;
using System.Text;

namespace Problem13Interfaces.Services
{
    interface IPaymentService
    {
        double ServiceTax(int months, double value);
    }
}
