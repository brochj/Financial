using System.Globalization;
using Financial.InterestContext.SimpleInterestContext;

namespace Financial.InterestContext.CompoundInterestContext
{
    public class CompoundInterest : IInterest<CompoundInterest>
    {
        public CompoundInterest()
        {
            Details = new List<CompoundInterest>();
        }
        public decimal Principal { get; set; }
        public decimal Amount { get; set; }
        public decimal RateOfInterest { get; set; }
        public decimal Time { get; set; }
        public decimal InterestValue { get; set; }
        public List<CompoundInterest> Details { get; set; }

        public decimal Calculate()
        {
            Amount = Principal * (decimal)Math.Pow((double)(1 + RateOfInterest), (double)Time);
            return Amount - Principal;
        }

        public void CalculateDetails()
        {
            throw new NotImplementedException();
        }

        public void GetInterestInputValues()
        {
            throw new NotImplementedException();
        }

        public void PrintValues()
        {
            throw new NotImplementedException();
        }

        public override string ToString()
        {
            return Calculate().ToString("C", CultureInfo.GetCultureInfo("pt-BR"));
        }

    }
}