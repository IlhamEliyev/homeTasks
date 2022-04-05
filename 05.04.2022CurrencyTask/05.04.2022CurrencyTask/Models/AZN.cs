using System;
using System.Collections.Generic;
using System.Text;

namespace _05._04._2022CurrencyTask.Models
{
    public class AZN
    {

        public readonly double Amount;
        public AZN(double Amount)
        {
            this.Amount = Amount;
        }
        public static implicit operator USD(AZN azn)
        {
            return new USD(azn.Amount * 0.59);
        }

        public static implicit operator Euro(AZN azn)
        {
            return new Euro(azn.Amount * 0.54);
        }

        public static bool operator >(AZN azn, USD usd)
        {
            return azn.Amount > usd.Amount * 0.59;
        }
        public static bool operator <(AZN azn, USD usd)
        {
            return azn.Amount > usd.Amount * 0.59;
        }
        public static bool operator >(AZN azn, Euro euro)
        {
            return azn.Amount > euro.Amount * 0.54;
        }
        public static bool operator <(AZN azn, Euro euro)
        {
            return azn.Amount > euro.Amount * 0.54;
        }
        public override string ToString()
        {
            return $"{Amount} AZN";
        }
    }
}
