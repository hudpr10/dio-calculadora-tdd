// See https://aka.ms/new-console-template for more information
using CalculadoraConsole.Services;

Calculadora calc = new Calculadora(DateTime.Now.ToShortDateString());

calc.Somar(1, 2);
calc.Dividir(6, 2);
calc.Multiplicar(6, 2);

foreach(string calculo in calc.Historico())
{
    Console.WriteLine(calculo);
}
