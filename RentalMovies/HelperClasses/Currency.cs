using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentalMovies.HelperClasses
{
    public class Currency
    {
        private int id;
        private static int defaultFractionDigits;
        public int getDefaultFractionDigits()
        {
            return defaultFractionDigits;
        }

        private Currency(int id, int fractionDigits)
        {
            this.id = id;
            defaultFractionDigits = fractionDigits;
        }

        public static Currency PL = new Currency(1, 2);

        override public bool Equals(object other)
        {
            return (other is Currency) && Equals((Currency)other);
        }

        public bool Equals(Currency other)
        {
            return id == other.id;
        }


    }
}
