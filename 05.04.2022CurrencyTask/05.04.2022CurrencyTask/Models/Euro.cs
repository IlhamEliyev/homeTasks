using System;
using System.Collections.Generic;
using System.Text;

namespace _05._04._2022CurrencyTask.Models
{
    public class Euro
    {

        public readonly double Amount;
        public Euro(double Amount)
        {
            this.Amount = Amount;
        }

        public static implicit operator AZN(Euro euro)
        {
            return new AZN(euro.Amount * 1.87);
        }

        public static implicit operator USD(Euro euro)
        {
            return new AZN(euro.Amount * 1.1);
        }
        public static bool operator >(Euro euro, AZN azn)
        {
            return euro.Amount  > azn.Amount * 1.87;
        }
        public static bool operator <(Euro euro, AZN azn)
        {
            return euro.Amount  > azn.Amount * 1.87;
        }
        public static bool operator >(Euro euro, USD usd)
        {
            return euro.Amount  > usd.Amount * 1.1;
        }
        public static bool operator <(Euro euro, USD usd)
        {
            return euro.Amount  > usd.Amount * 1.1;
        }
        public override string ToString()
        {
            return $"{Amount} - Euro";
        }

    }

}
