using Financial.StringExtensionsContext;
using System.Globalization;

namespace Financial.MenuContext
{
    public static class Print
    {
        public static void Header(string str, int totalWidth, char separator = '-', char paddingChar = ' ')
        {
            Console.WriteLine(new String(separator, totalWidth));
            Console.WriteLine(StringExtensions.PadSides(str, totalWidth, paddingChar));
            Console.WriteLine(new String(separator, totalWidth));
        }

        public static void CurrencyWithTitle(string title, decimal number, int totalWidth = 50, string cultureInfo = "pt-BR")
        {
            Console.Write(title);
            Console.Write(number.ToString("C", CultureInfo.GetCultureInfo(cultureInfo)).PadLeft(totalWidth - title.Length));
            Console.WriteLine();
        }

        public static void NumberWithTitle(string title, decimal number, int totalWidth = 50)
        {
            Console.Write(title);
            Console.Write(number.ToString().PadLeft(totalWidth - title.Length));
            Console.WriteLine();
        }
        public static void PercentageWithTitle(string title, decimal number, int totalWidth = 50)
        {
            Console.Write(title);
            Console.Write(number.ToString().PadLeft(totalWidth - title.Length - 2) + " %");
            Console.WriteLine();
        }
    }
}