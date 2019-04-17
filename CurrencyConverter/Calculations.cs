using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CurrencyConverter
{
   public class Calculations
    {
        public const double usd = 1.72761;
        public const double eur = 1.95583;
        public const double bgn = 1.0;
        public const double gbp = 2.26658;

        public static double CHANGE;

        public static double getCurrency(double amount, string currIn, string currOut)
        {
            double currencyIn = 0.0;
            double currencyOut = 0.0;
            double result = 0.0;

            switch (currIn)
            {
                case "USD":
                    currencyIn = usd;
                    break;
                case "EUR":
                    currencyIn = eur;
                    break;
                case "BGN":
                    currencyIn = bgn;
                    break;
                case "GBP":
                    currencyIn = gbp;
                    break;
                default:
                    break;
            }
            switch (currOut)
            {
                case "USD":
                    currencyOut = usd;
                    break;
                case "EUR":
                    currencyOut = eur;
                    break;
                case "BGN":
                    currencyOut = bgn;
                    break;
                case "GBP":
                    currencyOut = gbp;
                    break;
                default:
                    break;
            }
            result = amount*(currencyIn/currencyOut);
            CHANGE = getChange(amount, result, currencyIn, currencyOut);
            return result;
        }

        public static double getChange(double amount,double result, double currencyin, double currencyout)
        {
            double change = amount - (Math.Truncate(result) / (currencyin / currencyout));
            return change;
        }
    }
}
