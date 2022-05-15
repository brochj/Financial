using System.Globalization;
using Financial.MenuContext;

namespace Financial.InterestContext.SimpleInterestContext
{
    public class SimpleInterest : IInterest
    {
        public decimal Principal { get; set; }
        public decimal Amount { get; set; }
        public decimal RateOfInterest { get; set; }
        public decimal Time { get; set; }
        public decimal InterestValue { get; set; }

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

            Console.WriteLine("Digite o Capital Inicial:");
            Principal = decimal.Parse(Console.ReadLine());

            Console.WriteLine("Digite a taxa em %:");
            RateOfInterest = decimal.Parse(Console.ReadLine());

            Console.WriteLine("Digite o tempo da aplicação:");
            Time = decimal.Parse(Console.ReadLine());
        }
    }
}