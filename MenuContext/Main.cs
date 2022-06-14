using Financial.StringExtensionsContext;
using Financial.InterestContext;
using Financial.InterestContext.SimpleInterestContext;

namespace Financial.MenuContext
{
    public static class Main
    {
        public static int Menu()
        {
            Print.Header("Escolha o que quer calcular", 50, '=');
            Console.WriteLine("1 - Juros Simples");
            Console.WriteLine("2 - Juros Simples com aportes");
            Console.WriteLine("3 - Juros Compostos");
            Console.WriteLine("4 - Juros Compostos com Aportes");
            Print.Header("0 - Sair", 50, '-');

            string? option = Console.ReadLine();
            if (option != null)
                return int.Parse(option);
            return -1;
        }

        public static void Mode<T>(IInterest<T> Interest)
        {
            Console.Clear();
            Interest.GetInterestInputValues();
            Interest.Calculate();
            Interest.PrintValues();
            Interest.CalculateDetails();
        }
    }

}