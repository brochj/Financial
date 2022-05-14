namespace Financial.PeriodContext
{
    interface IPeriod
    {
        public double CurrentPeriod { get; set; }
        public double ConvertedPeriod { get; set; }
        double ToMonthly();
        double ToDaily();
        double ToHourly();
        double ToAnnually();
    }

    public abstract class Period : IPeriod
    {
        public abstract double CurrentPeriod { get; set; }
        public abstract double ConvertedPeriod { get; set; }
        public abstract double ToAnnually();
        public abstract double ToDaily();
        public abstract double ToHourly();
        public abstract double ToMonthly();
    }

}