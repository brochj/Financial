using Financial.PeriodContext;
using Financial.InterestContext.SimpleInterestContext;
using Financial.InterestContext.CompoundInterestContext;
// See https://aka.ms/new-console-template for more information
Console.Clear();
Console.WriteLine("Financial Calculator");

while (true)
{
    // Console.WriteLine("escolha o tipo de periodo:");
    // Console.WriteLine("1 - Anos");
    // Console.WriteLine("2 - Meses");
    // Console.WriteLine("3 - Dias");
    // Console.WriteLine("4 - Horas");
    // Console.WriteLine("");
    // Console.WriteLine("0 - Sair");

    // // Console.WriteLine("Digite a quantidade de anos: ");

    // int periodTyped = int.Parse(Console.ReadLine());



    // switch (periodTyped)
    // {
    //     case 1: var annualyPeriod = new Annually(); break;
    //     case 2: var period = new Annually(); break;
    //     case 3: Console.WriteLine("Dias"); break;
    //     case 4: Console.WriteLine("Horas"); break;
    //     case 0: Console.WriteLine("Sair"); break;
    // }

    Console.WriteLine("Digite o Capital Inicial:");
    decimal principal = decimal.Parse(Console.ReadLine());

    Console.WriteLine("Digite a taxa em %:");
    decimal rate = decimal.Parse(Console.ReadLine());

    Console.WriteLine("Digite o tempo da aplicação:");
    decimal time = decimal.Parse(Console.ReadLine());

    Console.WriteLine();
    Console.WriteLine("--------");


    Console.WriteLine("O Juros Simples será de: ");
    var simpleInterest = new SimpleInterest(principal, rate, time);
    Console.WriteLine(simpleInterest);

    Console.WriteLine("O Juros Composto será de: ");
    var compoundInterest = new CompoundInterest(principal, rate, time);
    Console.WriteLine(compoundInterest);

    Console.WriteLine();
    Console.WriteLine("--------");





}

