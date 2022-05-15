using Financial.StringExtensionsContext;
using Financial.InterestContext;

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

            int option = int.Parse(Console.ReadLine());
            return option;
        }

        public static void Mode(IInterest Interest)
        {
            Console.Clear();
            Interest.GetInterestInputValues();
            Interest.Calculate();
            Interest.PrintValues();
        }
    }

}