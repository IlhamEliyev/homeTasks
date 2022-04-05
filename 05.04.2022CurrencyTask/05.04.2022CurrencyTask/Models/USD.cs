using System;
using System.Collections.Generic;
using System.Text;

namespace _05._04._2022CurrencyTask.Models
{
    
        public class USD
        {
            public readonly double Amount;
            public USD(double Amount)
            {
                this.Amount = Amount;
            }

            public static implicit operator AZN(USD usd)
            {
                return new AZN(usd.Amount * 1.7);
            }

            public static implicit operator Euro(USD usd)
            {
                return new Euro(usd.Amount * 0.91);
            }


        public static bool operator >(USD usd, AZN azn)
        {
            return usd.Amount * 1.7 > azn.Amount;
        }
        public static bool operator >(USD usd, Euro euro)
        {
            return usd.Amount * 0.91 > euro.Amount;
        }
        public static bool operator <(USD usd, Euro euro)
        {
            return usd.Amount / 0.91 > euro.Amount;
        }
        public static bool operator <(USD usd, AZN azn)
        {
            return usd.Amount * 1.7 > azn.Amount;
        }
        public override string ToString()
        {
            return $"{Amount} USD";
        }
    }
}
