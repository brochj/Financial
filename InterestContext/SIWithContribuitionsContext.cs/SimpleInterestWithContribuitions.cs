using System.Globalization;
using Financial.InterestContext.SimpleInterestContext;

namespace Financial.InterestContext.SIWithContribuitionsContext
{
    public class SIWithContribuitions : IInterest<SIWithContribuitions>
    {
        public decimal Principal { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public decimal Amount { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public decimal RateOfInterest { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public decimal Time { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public decimal InterestValue { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public List<SIWithContribuitions> Details { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public decimal Calculate()
        {
            throw new NotImplementedException();
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
    }
}