using System.Globalization;

namespace Financial.InterestContext.SimpleInterestContext
{
    public class SimpleInterest : Interest
    {
        public SimpleInterest(
            decimal principal,
            // decimal amount,
            decimal rateOfInterest,
            decimal time
        )
        {
            base.Principal = principal;
            // base.Amount = amount;
            base.RateOfInterest = rateOfInterest;
            base.Time = time;
        }

        public decimal Calculate()
        {
            return base.Principal * base.RateOfInterest * base.Time;
        }

        public override string ToString()
        {
            return Calculate().ToString("C", CultureInfo.GetCultureInfo("pt-BR"));
        }
    }
}