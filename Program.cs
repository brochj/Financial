using Financial.PeriodContext;
using Financial.InterestContext.SimpleInterestContext;
using Financial.InterestContext.CompoundInterestContext;
using Financial.MenuContext;
using Financial.MenuContext.Enums;
using System.Globalization;

Console.Clear();

Print.Header("Financial Calculator", 50);
int option = Main.Menu();

switch (option)
{
    case (int)EOptions.Exit: Environment.Exit(Environment.ExitCode); break;
    case (int)EOptions.SimpleInterest: Main.Mode(new SimpleInterest()); break;
        // case (int)EOptions.SIWithContribuitions:; break;
        // case (int)EOptions.CompoundInterest:; break;
        // case (int)EOptions.CIWithContribuitions:; break;
        // default: 
}


