using System;
using Pessoas_e_Salarios;
using System.Security.Cryptography;


internal class Program
{
    private static object p1;

    private static void Main(string[] args)
    {
        Pessoas p1 = new Pessoas();
        Pessoas p2 = new Pessoas();

        Console.WriteLine(" Digite o nome da pessoa: ");
        Console.WriteLine(" Nome: ");
        p1.Nome = Console.ReadLine();
        Console.WriteLine(" Digite a idade da pessoa: ");
        p1.Idade =int.Parse( Console.ReadLine());

        Console.WriteLine(" Digite o nome da pessoa: ");
        Console.WriteLine(" Nome: ");
        p2.Nome = Console.ReadLine();
        Console.WriteLine(" Digite a idade da pessoa: ");
        p2.Idade = int.Parse(Console.ReadLine());

        if(p1.Idade < p2.Idade)
        {
            Console.WriteLine(p2.Nome + " Nasceu primeiro!");
        }
        else
        {
            Console.WriteLine(p1.Nome + " Nasceu primeiro!");
        }
        Salarios f1 = new Salarios();
        Salarios f2 = new Salarios();

        Console.WriteLine(" Digite o nome do Funcionário: ");
        Console.WriteLine(" Nome: ");
        f1.NomeFunc = Console.ReadLine();
        Console.WriteLine(" Digite o salário da pessoa: ");
        f1.SalarioFunc = int.Parse(Console.ReadLine());

        Console.WriteLine(" Digite o nome do Funcionário: ");
        Console.WriteLine(" Nome: ");
        f2.NomeFunc = Console.ReadLine();
        Console.WriteLine(" Digite o salário da pessoa: ");
        f2.SalarioFunc = int.Parse(Console.ReadLine());

        double media = (f1.SalarioFunc + f2.SalarioFunc) / 2;
        Console.WriteLine(" O salário médio é: " + media);

    }
}