namespace Financial.InterestContext
{
    public abstract class Interest
    {
        public decimal Principal { get; set; }
        public decimal Amount { get; set; }
        public decimal RateOfInterest { get; set; }
        public decimal Time { get; set; }
        public decimal InterestValue { get; set; }
    }

    public interface IInterest
    {
        public decimal Principal { get; set; }
        public decimal Amount { get; set; }
        public decimal RateOfInterest { get; set; }
        public decimal Time { get; set; }
        public decimal InterestValue { get; set; }
        public decimal Calculate();
        public void GetInterestInputValues();
        public void PrintValues();
    }
}