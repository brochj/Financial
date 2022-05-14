namespace Financial.PeriodContext
{
    public class Daily : Period
    {
        public override double CurrentPeriod { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public override double ConvertedPeriod { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public override double ToAnnually()
        {
            throw new NotImplementedException();
        }

        public override double ToDaily()
        {
            throw new NotImplementedException();
        }

        public override double ToHourly()
        {
            throw new NotImplementedException();
        }

        public override double ToMonthly()
        {
            throw new NotImplementedException();
        }
    }
}