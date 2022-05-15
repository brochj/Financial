using System.Globalization;
using Financial.MenuContext;

namespace Financial.InterestContext.SimpleInterestContext
{
    public class SimpleInterest : IInterest<SimpleInterest>
    {
        public SimpleInterest()
        {
            Details = new List<SimpleInterest>();
        }
        public decimal Principal { get; set; }
        public decimal Amount { get; set; }
        public decimal RateOfInterest { get; set; }
        public decimal Time { get; set; }
        public decimal InterestValue { get; set; }
        public List<SimpleInterest> Details { get; set; }

        public decimal Calculate()
        {
            InterestValue = Principal * (RateOfInterest / 100) * Time;
            Amount = Principal + InterestValue;
            return InterestValue;
        }

        public void PrintValues()
        {
            Print.Header("Juros Simples", 50, separator: '=');

            Print.PercentageWithTitle("Taxa de Juros em %:", RateOfInterest);
            Print.NumberWithTitle("Tempo Aplicado:", Time);
            Print.CurrencyWithTitle("Capital Inicial:", Principal);
            Print.CurrencyWithTitle("O Juros Simples será de:", InterestValue);
            Print.CurrencyWithTitle("Montante Final:", Amount);
        }

        public override string ToString()
        {
            return Calculate().ToString("C", CultureInfo.GetCultureInfo("pt-BR"));
        }

        public void GetInterestInputValues()
        {
            Print.Header("Juros Simples", 50, separator: '=');

            Principal = GetInputValue("Digite o Capital Inicial:");
            RateOfInterest = GetInputValue("Digite a taxa em %:");
            Time = GetInputValue("Digite o tempo da aplicação:");
        }

        decimal GetInputValue(string title)
        {
            Console.WriteLine(title);
            string? value = Console.ReadLine();
            if (value != null)
                return decimal.Parse(value);
            return -1;
        }

        public void CalculateDetails()
        // public List<SimpleInterest> Details()
        {
            var currentSI = new SimpleInterest();

            for (int i = 1; i <= Time; i++)
            {
                currentSI.Principal = Principal;
                currentSI.RateOfInterest = RateOfInterest;
                currentSI.Time = i;
                currentSI.Calculate();
                currentSI.PrintDetails();
                Details.Add(currentSI);
            }
        }

        public void PrintDetails()
        {
            Console.WriteLine(new String('-', 50));
            Print.PercentageWithTitle("Taxa de Juros em %:", RateOfInterest);
            Print.NumberWithTitle("Tempo Aplicado:", Time);
            Print.CurrencyWithTitle("Capital Inicial:", Principal);
            Print.CurrencyWithTitle("O Juros Simples será de:", InterestValue);
            Print.CurrencyWithTitle("Montante Final:", Amount);
        }

    }
}