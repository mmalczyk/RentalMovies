using System;
using System.Diagnostics;

namespace RentalMovies.HelperClasses
{
    public class Money : IComparable
    {
        private long amount = 0;
        private Currency currency;

        private static int[] cents = new int[] { 1, 10, 100, 1000 };

        public Money()
        {
            //intentionally nothing
        }

        public Money(double amount, Currency currency)
        {
            this.currency = currency;
            this.amount = (long)Math.Round(amount * centFactor());
        }

        public Money(string amount, Currency currency) : this(Convert.ToDouble(amount), currency)
        {
            //intentionally empty
        }

        public static Money zlotys(double amount)
        {
            return new Money(amount, Currency.PL);
        }

        public Money(long amount, Currency currency)
        {
            this.currency = currency;
            this.amount = amount * centFactor();
        }
        private int centFactor()
        {
            return cents[currency.getDefaultFractionDigits()];
        }

        override public bool Equals(object other)
        {
            return (other is Money) && Equals((Money)other);
        }
        public bool Equals(Money other)
        {
            return currency.Equals(other.currency) && (amount == other.amount);
        }

        override public int GetHashCode()
        {
            return (int)(amount ^ (amount >> 32));
        }

        public Money add(Money other)
        {
            assertSameCurrencyAs(other);
            return newMoney(amount + other.amount);
        }
        private void assertSameCurrencyAs(Money arg)
        {
            Debug.Assert(currency.Equals(arg.currency), "money math mismatch");
        }
        private Money newMoney(long amount)
        {
            Money money = new Money();
            money.currency = this.currency;
            money.amount = amount;
            return money;
        }

        public Money subtract(Money other)
        {
            assertSameCurrencyAs(other);
            return newMoney(amount - other.amount);
        }

        public int CompareTo(object other)
        {
            return CompareTo((Money)other);
        }
        public int CompareTo(Money other)
        {
            assertSameCurrencyAs(other);
            if (amount < other.amount) return -1;
            else if (amount == other.amount) return 0;
            else return 1;
        }

        public bool greaterThan(Money other)
        {
            return (CompareTo(other) > 0);
        }

        public Money multiply(double amount)
        {
            return new Money(this.amount*amount, currency);
        }

        override public string ToString()
        {
            return (amount % 100) + "." + (amount / 100);
        }
    }
}
