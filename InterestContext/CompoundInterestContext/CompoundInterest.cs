using System.Globalization;

namespace Financial.InterestContext.CompoundInterestContext
{
    public class CompoundInterest : Interest
    {
        public CompoundInterest(
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
            base.Amount = base.Principal * (decimal)Math.Pow((double)(1 + base.RateOfInterest), (double)base.Time);
            return base.Amount - base.Principal;
        }

        public override string ToString()
        {
            return Calculate().ToString("C", CultureInfo.GetCultureInfo("pt-BR"));
        }

    }
}