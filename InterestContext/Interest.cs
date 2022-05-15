using Financial.InterestContext.SimpleInterestContext;

namespace Financial.InterestContext
{
    public interface IInterest<T>
    {
        public decimal Principal { get; set; }
        public decimal Amount { get; set; }
        public decimal RateOfInterest { get; set; }
        public decimal Time { get; set; }
        public decimal InterestValue { get; set; }
        public List<T> Details { get; set; }

        public decimal Calculate();
        public void GetInterestInputValues();
        public void PrintValues();
        public void CalculateDetails();
    }
}