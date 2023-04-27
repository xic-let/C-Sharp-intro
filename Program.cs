using ConversorMoeda;
using System;
using System.Globalization;

internal class Program
{
    private static void Main(string[] args)
    {
        
        
        Console.WriteLine("Qual a Cotação do Dolar?");
        Console.WriteLine("Cotação:");
        double cotacao = double.Parse(Console.ReadLine());

        Console.WriteLine("Quantos Dolares vai comprar?");
        Console.WriteLine("Valor:");
        double quantidade = double.Parse(Console.ReadLine());

        double resultado = Dolar.dolar2euro(cotacao , quantidade);

        Console.WriteLine("Valor a ser pago em euros = " + resultado.ToString("F2")); 

    }
}

;