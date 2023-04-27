using System;
using System.Globalization;
using triangulo;

internal class Program
{
    private static void Main(string[] args)
    {
        Triangulo x, y; // declaração classe triangulo;
        x= new Triangulo(); // instaciar os objectos da classe
        y= new Triangulo();
        
        double trx, triy;
        //double p;

        Console.WriteLine("Triangulo x, Insira lado1:");
        x.A = double.Parse(Console.ReadLine());
        Console.WriteLine("Triangulo x,Insira lado2:");
        x.B = double.Parse(Console.ReadLine());
        Console.WriteLine("Triangulo x,Insira lado3:");
        x.C = double.Parse(Console.ReadLine());

        Console.WriteLine("Triangulo y, Insira lado1:");
        y.A = double.Parse(Console.ReadLine());
        Console.WriteLine("Triangulo y,Insira lado2:");
        y.B = double.Parse(Console.ReadLine());
        Console.WriteLine("Triangulo y,Insira lado3:");
        y.C = double.Parse(Console.ReadLine());

        /* = (x.A + x.B + x.C) / 2;
         trx = Math.Sqrt(p * (p - x.A) * (p - x.B) * (p - x.C));
         p = (y.A + y.B + y.C) / 2;
         triy = Math.Sqrt(p * (p - y.A) * (p - y.B) * (p - y.C));*/

         trx = x.Area();
         triy = y.Area();

         Console.WriteLine("Área do trinagulo X mede" + trx.ToString("F2"));
         Console.WriteLine("Área do trinagulo Y mede" + triy.ToString("F2"));


        if (trx > triy)
        {
            Console.WriteLine("Triangulo X tem a maior área");
        }
        else
        {
            Console.WriteLine("Triangulo Y tem a maior área ");
        }

    }
}