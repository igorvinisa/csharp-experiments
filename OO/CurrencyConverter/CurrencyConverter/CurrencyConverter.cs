using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CurrencyConverter
{
    public class CurrencyConverter
    {
        public static double Iof = 0.06;

        public static double ConvertToDollarWithIOF(double rate, double amount)
        {
            return rate * amount * Iof + rate * amount;
        }
    }
}
