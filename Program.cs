using retangulo;
using System;
using System.Diagnostics;

internal class Program
{
    private static void Main(string[] args)
    {
        calculos ret = new calculos();

        Console.WriteLine("Insira a Largura do Triangulo: ");
        Console.WriteLine("Largura:");
        ret.larg = double.Parse(Console.ReadLine());
        Console.WriteLine("Insira a Altura do Triangulo: ");
        Console.WriteLine("Altura:");
        ret.alt = double.Parse(Console.ReadLine());

        Console.WriteLine(ret);

    }
}